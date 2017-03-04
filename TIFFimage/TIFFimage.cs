// COPYRIGHT (c) 2017 Roberto Ceccarelli - CASASOFT
// http://strawberryfield.altervista.org 
// 
// This file is part of CASASOFT TIFFmanager
// 
// CASASOFT TIFFmanager is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// CASASOFT TIFFmanager is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with CASASOFT TIFFmanager.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using BitMiracle.LibTiff.Classic;
using System.Drawing;

namespace Casasoft.TIFFimage
{
    /// <summary>
    /// LibTIFF wrapper for GeoTiff
    /// </summary>
    public class TIFFimage
    {
#region properties
        protected Tiff Image;
        protected byte[][] Buffer;

        public int Width { get; protected set; }
        public int Height { get; protected set; }
        public int SamplesPerPixel { get; protected set; }
        public int BitsPerSample { get; protected set; }
        public int Photo { get; protected set; }
        public SampleFormat Format { get; protected set; }
        public string FormatString { get; protected set; }

        public string AllTags { get; protected set; }

        public double OriginX { get; protected set; }
        public double OriginY { get; protected set; }
        public double PixelSizeX { get; protected set; }
        public double PixelSizeY { get; protected set; }
        public string GeoAscii { get; protected set; }
        public double[] DoubleParams { get; protected set; }
        public short[] GeoDirectory { get; protected set; }

        public string Error { get; protected set; }
        #endregion

        #region GeoTiff tags

        protected const TiffTag GeoKeyDirectoryTag = (TiffTag) 34735;
        protected const TiffTag GeoDoubleParamsTag = (TiffTag) 34736;
        protected const TiffTag GeoAsciiParamsTag = (TiffTag) 34737;

        private static Tiff.TiffExtendProc m_parentExtender;

        /// <summary>
        /// Adds GeoTIFF tags to LibTiff
        /// </summary>
        /// <param name="tif"></param>
        public static void TagExtender(Tiff tif)
        {
            TiffFieldInfo[] tiffFieldInfo =
            {
                new TiffFieldInfo(TiffTag.GEOTIFF_MODELPIXELSCALETAG, 3, 3, TiffType.DOUBLE, FieldBit.Custom, true, true, "GeoTiff Pixel scale"),
                new TiffFieldInfo(TiffTag.GEOTIFF_MODELTIEPOINTTAG, 6, 6, TiffType.DOUBLE, FieldBit.Custom, true, true, "GeoTiff Coordinate"),
                new TiffFieldInfo(GeoAsciiParamsTag, -1, -1, TiffType.ASCII, FieldBit.Custom, true, true, "GeoTiff ASCII Data"),
                new TiffFieldInfo(GeoDoubleParamsTag, -1, -1, TiffType.DOUBLE, FieldBit.Custom, true, true, "GeoTiff Double Data"),  
                new TiffFieldInfo(GeoKeyDirectoryTag, -1, -1, TiffType.SHORT, FieldBit.Custom, true, true, "GeoTiff Directory"), 
            };

            tif.MergeFieldInfo(tiffFieldInfo, tiffFieldInfo.Length);

            if (m_parentExtender != null)
                m_parentExtender(tif);
        }

        #endregion

        #region costruttore
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fileName">GeoTiff file to manage</param>
        public TIFFimage(string fileName)
        {
            Width = 0;
            Height = 0;
            SamplesPerPixel = 0;
            BitsPerSample = 0;
            Format = SampleFormat.VOID;
            FormatString = "";

            OriginX = 0;
            OriginY = 0;
            PixelSizeX = 0;
            PixelSizeY = 0;

            Error = "";

            m_parentExtender = Tiff.SetTagExtender(TagExtender);

            using (Image = Tiff.Open(fileName, "r"))
            {
                if (Image == null)
                {
                    Error = $"Impossibile leggere il file {fileName}";
                    return;
                }
                getImageInfo();
                AllTags = getAllTags();
                readBuffer();
                Image.Close();
            }

        }
        #endregion

        /// <summary>
        /// Gets integer tag value
        /// </summary>
        /// <param name="tag">Tag ID</param>
        /// <returns></returns>
        private int getValue(TiffTag tag)
        {
            FieldValue[] value = Image.GetField(tag);
            if (value != null)
            {
                return value[0].ToInt();
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Gets array of bytes from tag
        /// </summary>
        /// <param name="tag">Tag ID</param>
        /// <returns></returns>
        private byte[] getBytes(TiffTag tag)
        {
            FieldValue[] value = Image.GetField(tag);
            if (value != null)
            {
                return value[1].GetBytes();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets Double value from tag
        /// </summary>
        /// <param name="tag">Tag ID</param>
        /// <returns></returns>
        private double[] getDoubles(TiffTag tag)
        {
            FieldValue[] value = Image.GetField(tag);
            if (value != null)
            {
                double[] ret = new double[value[0].ToInt()];
                byte[] data = value[1].GetBytes();
                for (var i = 0; i < ret.Length; i++)
                {
                    ret[i] = BitConverter.ToDouble(data, i*8);
                }
                return ret;
            }
            else
            {
                return null;
            }

        }

        /// <summary>
        /// Reads tags values
        /// </summary>
        private void getImageInfo()
        {
            Width = getValue(TiffTag.IMAGEWIDTH);
            Height = getValue(TiffTag.IMAGELENGTH);
            SamplesPerPixel = getValue(TiffTag.SAMPLESPERPIXEL);
            BitsPerSample = getValue(TiffTag.BITSPERSAMPLE);
            Photo = getValue(TiffTag.PHOTOMETRIC);

            int v = getValue(TiffTag.SAMPLEFORMAT);
            Format = (v > 0 ? (SampleFormat)v : SampleFormat.VOID);
            FormatString = Format.ToString();

            double[] modelPixelScale;
            if ((modelPixelScale = getDoubles(TiffTag.GEOTIFF_MODELPIXELSCALETAG)) != null)
            {
                PixelSizeX = modelPixelScale[0];
                PixelSizeY = modelPixelScale[1] * -1;
            }

            double[] modelTransformation;
            if ((modelTransformation = getDoubles(TiffTag.GEOTIFF_MODELTIEPOINTTAG)) != null)
            {
                OriginX = modelTransformation[3];
                OriginY = modelTransformation[4];
            }

            FieldValue[] res = Image.GetField(GeoAsciiParamsTag);
            if (res != null)
            {
                GeoAscii = res[1].ToString();
            }

            DoubleParams = getDoubles(GeoDoubleParamsTag);
            byte[] geoDir = getBytes(GeoKeyDirectoryTag);
        }

        /// <summary>
        /// Reads samples values
        /// </summary>
        private void readBuffer()
        {
            int scanlineSize = Image.ScanlineSize();
            Buffer = new byte[Height][];
            for (int i = 0; i < Height; ++i)
            {
                Buffer[i] = new byte[scanlineSize];
                Image.ReadScanline(Buffer[i], i);
            }

        }

        /// <summary>
        /// Convert samples to a Windows bitmap
        /// </summary>
        /// <returns></returns>
        public Bitmap GetBitmap()
        {
            byte[] buffer8Bit = null;
            Bitmap result = new Bitmap(Width, Height, PixelFormat.Format8bppIndexed);
            ColorPalette gray = result.Palette;
            for (var i = 0; i < gray.Entries.Length; i++)
            {
                gray.Entries[i] = Color.FromArgb(0, i, 0);
            }
            gray.Entries[0] = Color.Blue;
            gray.Entries[255] = Color.Red;
            result.Palette = gray;

            for (int i = 0; i < Height; i++)
            {
                Rectangle imgRect = new Rectangle(0, i, Width, 1);
                BitmapData imgData = result.LockBits(imgRect, ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);

                if (buffer8Bit == null)
                    buffer8Bit = new byte[imgData.Stride];
                else
                    Array.Clear(buffer8Bit, 0, buffer8Bit.Length);

                convertBuffer(Buffer[i], buffer8Bit);

                Marshal.Copy(buffer8Bit, 0, imgData.Scan0, buffer8Bit.Length);
                result.UnlockBits(imgData);
            }


            return result;
        }

        /// <summary>
        /// Gets min and max values of the samples
        /// </summary>
        /// <param name="minVal">out min value</param>
        /// <param name="maxVal">out max value</param>
        public void getMinMax(out int minVal, out int maxVal)
        {
            minVal = int.MaxValue;
            maxVal = int.MinValue;

            int[] bufferInt = new int[Width];
            for (var i = 0; i < Height; i++)
            {
                convertBuffer(Buffer[i], bufferInt);
                for (var j = 0; j < Width; j++)
                {
                    minVal = (bufferInt[j] < minVal ? bufferInt[j] : minVal);
                    maxVal = (bufferInt[j] > maxVal ? bufferInt[j] : maxVal);
                }
            }
        }

        /// <summary>
        /// Converts samples to 8 bit values
        /// </summary>
        /// <param name="buffer">raw data</param>
        /// <param name="buffer8Bit">converted values</param>
        private void convertBuffer(byte[] buffer, byte[] buffer8Bit)
        {
            int value;
            float floatValue;

            for (int src = 0, dst = 0; src < buffer.Length; dst++)
            {
                switch (BitsPerSample)
                {
                    case 8:
                        value = buffer[src++];
                        buffer8Bit[dst] = (byte)(value);
                        break;

                    case 16:
                        value = buffer[src++];
                        value = value + (buffer[src++] << 8);
                        buffer8Bit[dst] = (byte)(value / 257.0 + 0.5);
                        break;

                    case 32:
                        floatValue = BitConverter.ToSingle(buffer, src);
                        src += 4;
                        buffer8Bit[dst] = (byte)(floatValue >= 4000 ? 255 : floatValue / 8);
                        break;
                }
            }
        }

        /// <summary>
        /// Converts samples to integer values
        /// </summary>
        /// <param name="buffer">raw data</param>
        /// <param name="bufferInt">converted values</param>
        private void convertBuffer(byte[] buffer, int[] bufferInt)
        {
            int value;
            float floatValue;

            for (int src = 0, dst = 0; src < buffer.Length; dst++)
            {
                switch (BitsPerSample)
                {
                    case 8:
                        value = buffer[src++];
                        bufferInt[dst] = value;
                        break;

                    case 16:
                        value = buffer[src++];
                        value = value + (buffer[src++] << 8);
                        bufferInt[dst] = value;
                        break;

                    case 32:
                        floatValue = BitConverter.ToSingle(buffer, src);
                        src += 4;
                        bufferInt[dst] = Convert.ToInt16(floatValue);
                        break;
                }
            }
        }

        /// <summary>
        /// Clears "out of boundary" values
        /// </summary>
        public void Normalize()
        {
            if (BitsPerSample != 32) return;

            byte[] zero = BitConverter.GetBytes((float)0);

            for (int i = 0; i < Height; i++)
            {
                for (int src = 0, dst = 0; src < Buffer[i].Length; dst++)
                {
                    float floatValue = BitConverter.ToSingle(Buffer[i], src);
                    if (floatValue > 10000)
                    {
                        Array.Copy(zero, 0, Buffer[i], src, 4);
                    }
                    src += 4;
                }
            }
        }

        /// <summary>
        /// Reads all tags in the image
        /// </summary>
        /// <returns></returns>
        protected string getAllTags()
        {
            string s = "";
            short numberOfDirectories = Image.NumberOfDirectories();
            for (short d = 0; d < numberOfDirectories; ++d)
            {
                if (d != 0)
                    s += "---------------------------------\n";

                Image.SetDirectory((short)d);

                for (ushort t = ushort.MinValue; t < ushort.MaxValue; ++t)
                {
                    TiffTag tag = (TiffTag)t;
                    FieldValue[] value = Image.GetField(tag);
                    if (value != null)
                    {
                        for (int j = 0; j < value.Length; j++)
                        {
                            s += $"{tag.ToString()}\n";
                            s += $"{value[j].Value.GetType().ToString()} : {value[j].ToString()}\n";
                        }

                        s += "\n";
                    }
                }
            }

            return s;
        }

        #region salvataggio

        /// <summary>
        /// Saves the processed file
        /// </summary>
        /// <param name="filename"></param>
        public void Save(string filename)
        {
            using (Tiff output = Tiff.Open(filename, "w"))
            {
                output.SetField(TiffTag.IMAGEWIDTH, Width);
                output.SetField(TiffTag.IMAGELENGTH, Height);
                output.SetField(TiffTag.SAMPLESPERPIXEL, SamplesPerPixel);
                output.SetField(TiffTag.BITSPERSAMPLE, BitsPerSample);
                output.SetField(TiffTag.ROWSPERSTRIP, output.DefaultStripSize(0));
                output.SetField(TiffTag.PHOTOMETRIC, Photo);
                output.SetField(TiffTag.PLANARCONFIG, PlanarConfig.CONTIG);
                output.SetField(TiffTag.SAMPLEFORMAT, Format);

                double[] pixelScale = {PixelSizeX, PixelSizeY * -1, 0};
                output.SetField(TiffTag.GEOTIFF_MODELPIXELSCALETAG, pixelScale.Length, pixelScale);
                double[] coords = {0, 0, 0, OriginX, OriginY, 0};
                output.SetField(TiffTag.GEOTIFF_MODELTIEPOINTTAG, coords.Length, coords);
                output.SetField(GeoAsciiParamsTag, GeoAscii.Length, GeoAscii);
                output.SetField(GeoDoubleParamsTag, DoubleParams.Length, DoubleParams);

                for (int i = 0; i < Height; ++i)
                    output.WriteScanline(Buffer[i], i);
            }

 //           Tiff.SetTagExtender(m_parentExtender);
        }
        #endregion
    }
}
