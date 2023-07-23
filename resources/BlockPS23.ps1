New-NetFirewallRule -DisplayName "Adobe Photoshop Patch" -Direction Outbound -Action Block -Program "C:\Program Files\Adobe\Adobe Photoshop 2023\Photoshop.exe" -Description "ReFreeAdobe Photoshop 2023 Patch. DO NOT DELETE OR EDIT IT!"
$file = "C:\Windows\System32\drivers\etc\hosts"
$textToAdd = @"

#Adobe Patch Start
127.0.0.1 lcs-cops.adobe.io
127.0.0.1 lcs-robs.adobe.io
127.0.0.1 lcs-entitlement.adobe.io
127.0.0.1 lcs-ulecs.adobe.io
#Adobe Patch End
"@


$content = Get-Content -Path $file -Encoding UTF8
$content += $textToAdd

Set-Content -Path $file -Value $content -Encoding UTF8
