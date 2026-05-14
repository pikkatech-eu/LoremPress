; The name of the installer - might be changed later
Name "LoremPress"

; The file to write
OutFile "LoremPress_setup.exe"

; The default installation directory
InstallDir "$DESKTOP\LoremPress"

; Request application privileges for Windows Vista
RequestExecutionLevel user

; Pages
Page Directory
Page Instfiles
;--------------------------------
; The stuff to install
Section "Files" 
  ; Set output path to the installation directory.
  ; CreateDirectory "$INSTDIR"
  SetOutPath "$INSTDIR"
  
  ; Put files there
  File /r "..\Code\Binary\net6.0\*.dll"
  File /r "..\Code\Binary\net6.0\*.json"
  
SectionEnd ; end the section
