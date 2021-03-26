npm install showdown -g
showdown makehtml -i "$PSScriptRoot\README.md" -o "$PSScriptRoot\README.html"
showdown makehtml -i "$PSScriptRoot\LICENSE.md" -o "$PSScriptRoot\LICENSE.html"
showdown makehtml -i "$PSScriptRoot\CONTRIBUTING.md" -o "$PSScriptRoot\CONTRIBUTING.html"
showdown makehtml -i "$PSScriptRoot\CODE_OF_CONDUCT.md" -o "$PSScriptRoot\CODE_OF_CONDUCT.html"
showdown makehtml -i "$PSScriptRoot\bug-report.md" -o "$PSScriptRoot\bug-report.html"
showdown makehtml -i "$PSScriptRoot\feature_request.md" -o "$PSScriptRoot\feature_request.html"
Remove-Item "$PSScriptRoot\*.md"
Remove-Item "$PSScriptRoot\*.ps1"