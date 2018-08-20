# csharp_mdns_linux


## UDP Reflector
Project was found on google archive! https://code.google.com/archive/p/udp-reflector/

Build it with the `build` file: `./build` (only tested in linux)

This tool is being used to allow developers to work with Socket binding in linux, as mono implementation seems to disallow port acquisition if other processes are already using it, resulting in an 'Address already in use'.

in one tty do this:
`sudo ./udp_reflector -s pcap1:5354 -d 192.168.1.255:5353 -b 50002 -i 50001 -v`
`sudo ./udp_reflector -s pcap2:5353 -d 192.168.1.255:5354 -b 50001 -i 50002 -v`

Now you are effectively able to use port 5354 as if it was 5353! Just double check the port you use is not busy with:
`sudo lsof -i :[port]`
