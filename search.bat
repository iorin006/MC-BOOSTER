@echo off
NET SESSION >nul 2>&1
if %errorLevel% == 0 (
    cd /
    echo ファイルを検索中　時間がかかる場合はエンターキーを押してください
    dir /s /b Minecraft.Windows.exe > "%~dp0path.txt"
    echo 検索が終了しました
) else (
    echo 管理者権限で実行してください
)
pause