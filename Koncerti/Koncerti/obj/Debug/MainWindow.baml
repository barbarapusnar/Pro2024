   M S B A M L   `   `   `  ����C  ?Koncerti, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:KoncertiKoncerti  5   	       Koncerti.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Koncerti     5   	     � Title$  
MainWindow��5   	   $	��338��6   $	��489��6)    � 	Resources 5	        Koncerti.NakupKarte 	  nakup  Koncerti.PLKonverter  plKonverter  
napakaStil �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� Self	 �� RelativeSource
 �� Path��%  &	        &	      &	 &       5
   
   6     5   
   6   �� 5   
   " ��6#    5      P� 5       �@=�HasError . . �5      ��  �@�ToolTip 5      �� #	 Z $)
 #(Validation.Errors)[0].ErrorContent�5      5      5      .��5      � .+�5   
   �� $
��Left=�6   $��	40,40,0,0q�6/   $
��Wrap=�6B   $��Dogodek��6V   $	��Top=�6e   �� 5   
   $
��Left=�6   $��	40,80,0,0q�6/   $
��Wrap=�6B   $��Kupec��6V   $	��Top=�6c   �� 5   
   $
��Left=�6   $��
40,120,0,0q�6/   $
��Wrap=�6C   $��Status��6W   $	��Top=�6e   �� 5   
   $
��Left=�6   $��
40,160,0,0q�6/   $
��Wrap=�6C   $��Število kart��6W   $	��Top=�6k   �� 5   
   -   5         ��Name$ 
cboDogodek��5      $
��Left=�6'   $��
196,34,0,0q�6B   $	��Top=�6V   $	��120��6n   #���  6�    �� Text 6z   �� *
ImeDogodka+ �� Mode$ TwoWay=� �� Source# [   �� ValidatesOnExceptions . .@�5      �� $�� ��6   �� 5      $��AC DC��6   �� 5      $��Rock otočec��6   �� 5      $��
Omar Naber��6   �� 5      $��
Lady Ga-ga��6   5       �� 5!   
   -   5         ��Name$ txtKupec��5!      $
��Left=�6$   $��
196,70,0,0q�6?    �� TextWrapping$
 Wrap=�6S   $	��Top=�6g   $	��120��6   #���  6�   ��6�   �� *
ŠtKupca+$ TwoWay=�# [   . 6�   �� 5"   
   -   5        $ 	cboStatus��5"      $
��Left=�6&   $��196,117,0,0q�6A   $	��Top=�6V   $	��120��6n   #���  6    6z   �� *Nivo+ �� 	Converter# [ $ TwoWay=�# [   . .@�5#      �� $��Standard��6   �� 5$      $��Premium��6   �� 5%      $��	Executive��6   �� 5&      $��Premium executive��6   5'      �� 5(   
   -   5         ��Name$ sldŠtevilo��5(      $
��Left=�6%   $��196,159,0,0q�6@   $	��Top=�6U   $	��120��6m    � SmallChange$ 1Q�6y    �� IsSnapToTickEnabled . #���  6	   � Value 6�   �� *ŠtVstopnic+$ TwoWay=�# [   . 6	  �� 5)   
   $
��Left=�6   $��358,160,0,0q�6-   $
 Wrap=�6B   $	��Top=�6�   $��68��6�   $��17��6�   ��6V   �� *Value+ �� ElementName$ sldŠtevilo��6�   �� 5*   
   $��Kupi!��6   $
��Left=�6!   $��
40,217,0,0q�6<   $	��Top=�6P   $��59��6h   5+      5,      