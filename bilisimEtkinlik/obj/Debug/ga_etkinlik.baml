   M S B A M L   `   `   `  ����  bilisimEtkinlik!    bilisimEtkinlik.ga_etkinlik   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  Etkinlik Takip��5   	   $	��500��6    $
��1200��6-    � AllowsTransparency .  � WindowStyle$
 None=�6T   .��5      � ���#333 � RowDefinitions 5   
   �� 5      $	��56* �6   �� 5	      $	��69* �6   .+�5   
   ]� $��70��6   $��25��6   $��Right=�6+   $	��Top=�6G   .+�5      �� -   5         ��Name$ btn_ky��5      $��_��6%   $��35��61   
�������   miniButonlar#���   6P   
�������6w   �� 5      -   5        $ 	btn_kapat��5      $��X��6(   $��35��6L   
�������#���   6j   
�������6�   5      �� 5   
   $�� ��6   $
��Left=�6   $��	10,10,0,0q�66   $	��Top=�6I   
�������$��
Montserrat)�6t   $��20(�6�   �� 5   
   -   5         ��Name$ lbl_hg��5      $�� ��6    $
��Left=�6+   $��	20,25,0,0q�6F   $	��Top=�6Y   
�������$��	Open Sans)�6�   $	��274��6�   ��6�   Z� 6�   �� 5   
   -   5        $ s_Glory��5      $�� ��6"     MyButton#��[ 6-   $
��Left=�6Q   $��	20,89,0,0q�6l   $	��Top=�6   $��60��6�   $��60��6�   $��
Montserrat)�6�   ���	#FF7C7C7C
���������5      �� 5       �� ImageSource$ img/glory.png��6   5      �� 5   
   -   5        $ s_Gameg��5      $�� ��6"   #��[ 6-   $
��Left=�6O   $��
20,153,0,0q�6j   $	��Top=�6~   $��60��6�   $��60��6�   $��
Montserrat)�6�   
������� J� RenderTransformOrigin$ 	0.55,1.35&�6�   
���������5      �� 5      $ img/gameg.png��6   5      �� 5   
   -   5        $ s_Mello��5      $�� ��6"   #��[ 6-   $
��Left=�6O   $��
20,219,0,0q�6j   $	��Top=�6~   $��60��6�   $��60��6�   $��
Montserrat)�6�   
�������$ 	0.55,1.35&�6�   $��2��6�   
���������5      �� 5      $ img/mello.png��6   5       �� 5!   
   -   5        $ s_Faggo��5!      $�� ��6"   #��[ 6-   $
��Left=�6O   $��	20,59,0,0q�6j   $	��Top=�6}   $��60��6�   $��60��6�   $��
Montserrat)�6�   
�������$ 	0.55,1.35&�6�   $��1��6�   
���������5"      �� 5#      $ img/faggo.png��6   5%      �� 5&   
   -	   5        $ lbl_hg_Copy��5&      $��
Şirketler��6%   $
��Left=�69   $��	23,60,0,0q�6T   $	��Top=�6g   ���	#FF333333$��	Open Sans)�6�   ��6�   Z� �� 5'   
   $	��???��6   $
��Left=�6   $��
20,125,0,0q�6:   $	��Top=�6N   $��60��6f   $��60��6q   $��
Montserrat)�6}   ���	#FF333333$��1��6�   ���	#FF333333��6�   Z� 6�   �� 5(   
   $	��???��6   $
��Left=�6   $��
20,190,0,0q�6:   $	��Top=�6N   $��60��6f   $��60��6q   $��
Montserrat)�6}   ���	#FF333333$ 	0.55,1.35&�6�   $��1��6�   ���	#FF333333��6�   Z� 6�   � 5)   
   -
   5         �Name$ rectangle_md��5)      $
��Left=�6%   $��25��6@   $	��Top=�6L   $
��1130��6d   ���	#7F0000006�   &   System.Windows.Controls.DataGrid  5*   
   -   5        	  Name$	 my_grid��5*      $
��Left=�6$   $��
120,65,0,0q�6?   $	��Top=�6S   $	��409��6k   $	��700��6x   ���	#FF757575���	#FFFAFAFA$��
Montserrat)�6�   $��10(�6�   
   MaxColumnWidth$	
 105Q�6�      MinColumnWidth$ 80Q�6     VerticalGridLinesBrush �#666   RowBackground �	#FF333333$��2��6�     AreRowDetailsFrozen . ��6�   Z�    HorizontalGridLinesBrush 6  Z� 5:      �� 5;   
   -   5         ��Name$	 ara��5;      $
��Left=�6   $��24��6:   $��904,102,0,0q�6F    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��208��6�   ���	#7F000000
���������6�   Z� 6�   �� 5<   
   $��İsme göre üye ara��6   $��Center=�6,   $��931,68,130,0q�6I   $	��Top=�6_   $ 0.553,-0.038&�6w   $��
Montserrat)�6�   ���	#FF1F9E4C$	��139��6�   $��14(�6�   $��26��6�   ��6�   Z� 6�   5=      5>      