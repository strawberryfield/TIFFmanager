# TIFFmanager
##GeoTiff Explorer

Some years ago I wrote a little program to download DEM data from the italian "Portale Cartografico Nazionale" (http://www.pcn.minambiente.it/GN/) available at http://www.trainsimhobby.net/infusions/pro_download_panel/download.php?did=1340

When I wrote it I needed to download data for Ahrntal in South Tirol and the program worked fine.
Some weeks ago I downloaded the data for a region near Rimini on the Adriatic sea.

When I used that data in the railways simulator I saw an hight wall where I espected to see the sea ![The problem](http://win.simtreni.net/public/allegati/strawberryfield/201724154128_Open%20Rails%202017-02-04%2003-34-02.jpg)
The reason is that the data have a 32000 sample (altitude in meters) few meters from the coast to mark the end of valid data.

This tool borns to investigate the problem and to solve it, but can be useful to learn as GeoTiff are built

