@echo off
NET SESSION >nul 2>&1
if %errorLevel% == 0 (
    cd /
    echo �t�@�C�����������@���Ԃ�������ꍇ�̓G���^�[�L�[�������Ă�������
    dir /s /b Minecraft.Windows.exe > "%~dp0path.txt"
    echo �������I�����܂���
) else (
    echo �Ǘ��Ҍ����Ŏ��s���Ă�������
)
pause