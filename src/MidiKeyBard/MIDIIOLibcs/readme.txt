/******************************************************************************/
/*                                                                            */
/*  MIDIIOLib0.8_csライブラリ「はじめにお読みください」        (C)2012  友水  */
/*                                                                            */
/******************************************************************************/

  このたびは、MIDIIOLib0.8_csライブラリをダウンロードしていただき、又はお受け
取りになっていただき、誠にありがとうございます。


このモジュールはくず氏のMIDIIOLib0.8用のC#用ラッパを提供します。
MIDIIOLibの著作権は"(C)2002-2012 くず / おーぷんMIDIぷろじぇくと"様が保有して
います。


【特徴】
MIDIIOLibをC#から利用しやすいように、ラッパークラスとして実装。


【添付ファイル】
MIDIIOLib0.8_cs0.3
├readme.txt               はじめにお読みください(このファイル)
├license.txt              本ライブラリのライセンス文(英文)
├license_jp.txt           本ライブラリのライセンス文(和訳)
│
├build
│├build.bat              DLL作成実行ファイル
│├readme.txt             DLL作成の説明
│└data
│  ├make_release_dll.bat DLL作成バッチファイル(release)
│  ├make_debug_dll.bat   DLL作成バッチファイル(debug)
│  ├MIDIIO_cs.i          SWIGインターフェイスファイル
│  └MIDIIO_cs.rb         rubyファイル
│
├Debug
│├MIDIIO.CSharp.dll      C#参照用DLL(debug)
│└MIDIIO_cs.dll          C#ラッパDLL(debug)
│
├Release
│├MIDIIO.CSharp.dll      C#参照用DLL(release)
│└MIDIIO_cs.dll          C#ラッパDLL(release)
│
└docs
  └MIDIIOLib0.8_cs.chm    説明文


【使用方法】
本ライブラリは単体では使用できません。くず氏のライブラリMIDIIOLibと併用して使
用して下さい。詳細については、docs/MIDIIOLib0.8_cs.chmを参照して下さい。

【プラットフォーム】
Win32

【ライセンス】
本ライブラリはBSDライセンスを採用していますが、リンク先のライブラリである
MIDIIOLibのライセンス形態はLGPLであるため注意が必要です。


LGPLについては以下を参照して下さい。
日本語訳：http://www.opensource.gr.jp/lesser/lgpl.ja.html


※おーぷんMIDIぷろじぇくとに記載されていますがダイナミックリンク形式を利用す
ることで、LGPL以外のライセンスで配布することは可能です。詳細はくず氏のホーム
ページを参照して下さい。

※本ライブラリはくず氏のdllを使用しており。直接コードをコンパイルはしていません。


【本家】
"(C)2002-2012 くず / おーぷんMIDIぷろじぇくと"
・プロジェクトホームページ http://openmidiproject.sourceforge.jp/index.html


【謝辞】
このような便利なライブラリをオープンソースという形で提供して頂いたくず氏にこの場
を借りてお礼申し上げます。


【連絡先】
E-Mail : pchousuuアットyahoo.co.jp
URL    : http://www.geocities.jp/yuusui_housuu/openmidiproject/index.html