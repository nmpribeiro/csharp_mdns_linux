# csharp_mdns_linux


## Hello World
It's a C# little program coupled with a slightly modified Tmds.MDns library: https://github.com/tmds/Tmds.MDns
It serves to assert that we can indeed reflect packets from the 5353 port to 5354, both IN and OUT directions, and allow us to workaround the limitations of mono or dotnet "System.Net.Sockets;" implementation in linux.

To make it work:
cd to the directory and to the following:
`dotnet restore`
`dotnet build`
`dotnet run`

Then you should be able to see `_workstations._tcp.local` services popping in and out of existence. If not, just update your service name/type accordingly.

## UDP Reflector
Project was found on google archive! https://code.google.com/archive/p/udp-reflector/

Build it with the `build` file: `./build` (only tested in linux)

This tool is being used to allow developers to work with Socket binding in linux, as mono implementation seems to disallow port acquisition if other processes are already using it, resulting in an 'Address already in use'.

in one tty do this:
`sudo ./udp_reflector -s pcap1:5354 -d 192.168.1.255:5353 -b 50002 -i 50001 -v`
`sudo ./udp_reflector -s pcap2:5353 -d 192.168.1.255:5354 -b 50001 -i 50002 -v`

Now you are effectively able to use port 5354 as if it was 5353! Just double check the port you use is not busy with:
`sudo lsof -i :[port]`
