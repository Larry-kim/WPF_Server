   M S B A M L   `   `   `  ����E  AWpfServer1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfServer1
WpfServer1  5   	       WpfServer1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfServer1     5   	     � Title$  Server��5   	   $	��450��6   $	��800��6%   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��10* �6   �� 5      $	��20* �6   .+�5   
   �� -   5         ��Name$ StartBtn��5      $��시작��6#   $
��Left=�60   $��	10,22,0,0q�6K   $	��Top=�6^   $��45��6v   $	��100��6�   $��18(�6�   6�   �� 5   
   -   5        $ StopBtn��5      $��중지��6"   $
��Left=�6/   $��
127,22,0,0q�6J   $	��Top=�6^   $��45��6v   $	��100��6�   $��18(�6�   6�   �� 5   
   -   5         ��Name$ RichTextBox1��5      $��16(�6,   $��10,119,10,10q�6:   $
��True��6P   $��1��6u   . �5      /� .T�5      J� .*�6   .*�5      �� 5      5      5      �� 5   
   -   5        $ RichTextBox2��5      $��10,119,10,10q�6,   $��16(�6B   $
��True��6P   . �5       /� .T�5!      J� .*�6   .*�5"      �� 5#      5$      5%      �� 5'   
   $��Connected Clients��6   $
��Left=�6,   $��	10,88,0,0q�6G   $	��Top=�6Z   $��16(�6r   $
��Bold"�6�   �� 5)   
   $��Messages��6   $
��Left=�6#   $��	10,88,0,0q�6>   $	��Top=�6Q   $��16(�6i   $��1��6w   $
��Bold"�6�   5+      5,      