param([string]$msg, [string]$brench = "master")

if (!$msg) { 
Write-Host "Parameter : msg is null" 
exit
}


echo "--Code synchronization with master--"
echo "[vtts git status ]:"
git status
Start-Sleep -s 5

echo "[-- syn GenericWinFormProject --]"
cd .\GenericWinFormProject
git status
git add .
git commit -m "$msg"
git push
Start-Sleep -s 5
cd ..

echo "----GenericWinFormTest ynchronization with master--"

cd .\GenericWinFormTest
git status
git add .
git commit -m "$msg"
git push
Start-Sleep -s 5
cd ..
git status
git add .
git commit -m "$msg"
git push
Start-Sleep -s 5