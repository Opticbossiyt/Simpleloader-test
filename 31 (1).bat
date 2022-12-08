@echo off
:loop
setlocal
call :setESC

echo ^%ESC%[31m MOTHERBOARD %ESC%[0m
wmic baseboard get product,Manufacturer,serialnumber 

echo ^%ESC%[31m BIOS %ESC%[0m
wmic bios get manufacturer,serialnumber,version,smbiosbiosversion,releasedate 
wmic csproduct get name,identifyingnumber,uuid 

echo ^%ESC%[31m RAM %ESC%[0m
wmic memorychip get partnumber, serialnumber, sku

echo ^%ESC%[31m MAC %ESC%[0m
wmic nic get macaddress, description 

echo ^%ESC%[31m GPU %ESC%[0m 
cd C:\Program Files\NVIDIA Corporation\NVSMI
nvidia-smi -L
@echo.

echo ^%ESC%[31m CPU %ESC%[0m
wmic cpu get caption, processorid, socketdesignation, Name, Caption 

echo ^%ESC%[31m HARD DRIVES %ESC%[0m
wmic logicaldisk where drivetype=3 get name,volumeserialnumber
wmic diskdrive get Model, SerialNumber, name
echo ^%ESC%[31m WINDOWS %ESC%[0m
wmic OS GET Caption,SerialNumber,CSName
wmic computersystem get PrimaryOwnerName
pause
goto loop

:setESC
for /F "tokens=1,2 delims=#" %%a in ('"prompt #$H#$E# & echo on & for %%b in (1) do rem"') do (
  set ESC=%%b
  exit /B 0
)
exit /B 0