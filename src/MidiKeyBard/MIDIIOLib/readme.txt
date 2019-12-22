/******************************************************************************/
/*                                                                            */
/*  MIDIIO���C�u�����u�͂��߂ɂ��ǂ݂��������v             (C)2002-2016 ����  */
/*                                                                            */
/******************************************************************************/

�@���̂��т́AMIDIIO���C�u�������_�E�����[�h���Ă��������A���͂��󂯎��ɂȂ�
�Ă��������A���ɂ��肪�Ƃ��������܂��B

�@MIDIIO���C�u�����́A�t���[�ŃI�[�v���\�[�X�́AMIDI���b�Z�[�W���o�͗p���C�u����
�ł��B���̃��C�u�����́AMIDI�f�o�C�X�̃I�[�v���E�N���[�Y�AMIDI���b�Z�[�W�̑��M�E
��M�ȂǁAMIDI�̓��o�͂���舵����ŕK�v�s���ȋ@�\��񋟂��Ă��܂��B

�y�����z

1.�ώG��MIDI���o��API�֐����ȑf���B
�@MIDI�֌W�̃A�v���P�[�V���������ɂ́AC�����Win32API�֐����g�����Ƃ���ʓI
�ł��B�������A�ᐅ��MIDI���o�͊֐��͈���������A���ɃV�X�e���G�N�X�N���[�V�u
���b�Z�[�W���������߂ɂ͔ώG�����i�ȃ������Ǘ����s��Ȃ���΂Ȃ�܂���BMIDI
IO���C�u�������g���΁AMIDI���b�Z�[�W�̎�ނɊ֌W�Ȃ��A�ȒP��MIDI���o�͂��ł���
���B


�y�Y�t�t�@�C���z

MIDIIO
��readme.txt        �͂��߂ɂ��ǂ݂�������(���̃t�@�C��)
��license.txt       ���C�Z���X(�����E�p��)
��MIDIIO.c          C�\�[�X�t�@�C��
��MIDIIO.h          C/C++�p�w�b�_�[�t�@�C��
��MIDIIO.def        C/C++�p���W���[����`�t�@�C��(dll�����Ƃ��ɕK�v)
��MIDIIO.mak        C/C++�p���C�N�t�@�C��
��MIDIIO.sln        Visual C++ 2008 Service Pack 1�p�\�����[�V�����t�@�C��
��MIDIIO.vcproj     Visual C++ 2008 Service Pack 1�p�v���W�F�N�g�t�@�C��
��MIDIIO.bas        Visual Basic 4.0/5.0/6.0�p�C���|�[�g���W���[��
��Debug
����MIDIIOd.lib     �I�u�W�F�N�g���C�u�������W���[��(�f�o�b�O�p)
����MIDIIOd.dll     �_�C�i�~�b�N�����N���C�u����(�f�o�b�O�p)
��Release
����MIDIIO.lib      �I�u�W�F�N�g���C�u�������W���[��(�����[�X�p)
����MIDIIO.dll      �_�C�i�~�b�N�����N���C�u����(�����[�X�p)
��docs
�@��MIDIIO.html     �����K�C�h�u�b�N
�@��MIDIIO02.gif    �����K�C�h�u�b�N�Ŏg���Ă���}
�@��MIDIIn.gif      �����K�C�h�u�b�N�Ŏg���Ă���}
�@��MIDIOut.gif     �����K�C�h�u�b�N�Ŏg���Ă���}
�@��MIDIThru.gif    �����K�C�h�u�b�N�Ŏg���Ă���}


�y�g�p���@�z

�E���ׂẴt�@�C�����𓀂��Ă��������B
�EMIDIIO.h��VisualC++���C���X�g�[�������t�H���_����include�t�H���_���ɃR�s�[���Ă��������B
�EMIDIIO.lib��VisualC++���C���X�g�[�������t�H���_����lib�t�H���_���ɃR�s�[���Ă��������B
�EMIDIIO.dll�t�@�C����c:\windows\System32\��(32bitOS�̏ꍇ)�A
�@c:\windows\SysWOW64\��(64bitOS�̏ꍇ)�ɃR�s�[���Ă��������B
�EMIDIIO���C�u�������g�p����\�[�X�ł́A#include "MIDIIO.h"���s���Ă��������B
�E�u�r���h(B)�v-�u(�v���W�F�N�g��)�̃v���p�e�B�v����u(�v���W�F�N�g��)�̃v���p�e�B�y�[�W�v�Ƃ���
�@�_�C�A���O��\�������A���̒��́u�\���ƃv���p�e�B�v�́u�����J�v�́u���́v�̒��ɁA
�@�u�ǉ��̈ˑ��t�@�C���v�Ƃ������ڂ�����̂ŁA������MIDIIO.lib��ǉ����Ă��������B
�E�A�v���P�[�V������z�z����ۂɂ́AMIDIIO.dll��exe�t�@�C���Ɠ����t�H���_�ɓY�t���Ă��������B
�E�ڂ����́A���[�Ղ�MIDI�Ղ낶�����Ƃ̎�������FAQ�̃y�[�W���Q�Ƃ��Ă��������B

�y���C�Z���X�z

�@���̃��C�u�����́AGNU �򓙈�ʌ��O���p�����_��(LGPL)�Ɋ�Â��Ĕz�z����܂��B
�E���Ȃ��͂��̃��C�u�������ALGPL�Ɋ�Â��A�����E�]�ځE�z�z���邱�Ƃ��ł��܂��B
�E���Ȃ��͂��̃��C�u���������ς��邱�Ƃ��ł��A�����LGPL�Ɋ�Â��z�z���邱�Ƃ��ł��܂��B
�E���Ȃ��͂��̃��C�u������DLL�𗘗p����(�_�C�i�~�b�N�����N�Ɍ���)�A���Ȃ��Ǝ���
�@���C�Z���X�̃A�v���P�[�V�����𐻍�E�z�z���邱�Ƃ��ł��܂��B
�E������̏ꍇ����҂ɋ��𓾂�K�v�͂���܂���B
�E���̃��C�u�����͑S���̖��ۏ؂ł��B
�@���̃��C�u�������g�p�������ʐ��������Q�ɂ��܂��č�҂͈�ؐӔC�𕉂��܂���B
�@���炩���߂��������������B
���ڂ����́ALGPL�̓��{���(http://www.opensource.gr.jp/lesser/lgpl.ja.html)�����Q�Ƃ��������B

�y�A����z

�E���[���A�h���X(��) ee65051@yahoo.co.jp
�E�v���W�F�N�g�z�[���y�[�W http://openmidiproject.osdn.jp/index.html

