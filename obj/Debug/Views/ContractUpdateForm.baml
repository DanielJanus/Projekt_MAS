   M S B A M L   `   `   `  ����L  HMAS-Implementacja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:MAS_Implementacja.ViewsMAS_Implementacja.Views  5   	   0    *MAS_Implementacja.Views.ContractUpdateForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:MAS_Implementacja.Views     5   	     � Title$  ContractUpdateForm��5   	   $��733.167��6$   $	��714��65   .��5	      � $	��706��6   $	��Top=�6   $��	0,0,-8,-4q�60   ��5
   
   �� 5       �� ImageSource$T NG:\Users\Daniel\source\repos\MAS-Implementacja\Assets\Universal\Background.png��6   .+�5   
   �� $��Center=�6   $��75��61   
���   �
���   �$	��Top=�6Y   $
��1920��6q   $
��-4,0q�6~   �� 5   
   $��DREAM'S��6   $��50(�6#   $
��Left=�61   $��	-1,-4,0,0q�6L   $	��Top=�6_   #��[" �6w   ���#B22D2D$
��Bold"�6�   �� 5   
   $	��GYM��6   $��25(�6   $
��Left=�6-   $��
196,23,0,0q�6H   $	��Top=�6\   #��[" �6t   
�������$
��Bold"�6�   $��40��6�   $	��116��6�   �� 5   
   
���   �$
��Left=�6!   $��44��6<   $��	0,662,0,0q�6H   
���   �$	��Top=�6j   $	��714��6�   �� 5   
   $
��Left=�6   $��
10,676,0,0q�6/   $
��Wrap=�6C   $5��/DREAM'SGYM © 2021 Wszystkie prawa zastrzeżone��6W   $	��Top=�6�   ���	#FF514E4E$��15(�6�   �� 5   
   
���   �$��center=�6!   $	��497��6>   $��48,144,50,0q�6K   
���   �$	��Top=�6o   $	��616��6�   �� 5   
   ���	#FFACACAC$
��Left=�6%   $��54��6@   $��
56,184,0,0q�6L   
���   �$	��Top=�6o   $	��594��6�   �� 5   
   $��IdUmowa:��6   $
��Left=�6#   $��
56,152,0,0q�6>   $	��Top=�6R   
�������
���   �$��16(�6�   �� 5   
   -   5         ��Name$ txtIdUmowaUpdate��5      $��22��6,   $��62,200,72,0q�68    �� TextWrapping$
 Wrap=�6M   $	��Top=�6a   $��18(�6y   
���   ����	#FFACACAC6�   �� 5   
   ���	#FFACACAC$
��Left=�6%   $��54��6@   $��
56,268,0,0q�6L   
���   �$	��Top=�6o   $	��594��6�   �� 5   
   $��RodzajUmowy:��6   $
��Left=�6'   $��
56,238,0,0q�6B   $	��Top=�6V   
�������
���   �$��16(�6�   �� 5   
   -   5        $ txtRodzajUmowyUpdate��5      $��24��60   $��62,286,72,0q�6<   $
 Wrap=�6Q   $	��Top=�6e   $��18(�6}   
���   ����	#FFACACAC6�   �� 5   
   ���	#FFACACAC$
��Left=�6%   $��54��6@   $��
56,354,0,0q�6L   
���   �$	��Top=�6o   $	��594��6�   �� 5   
   $��DataRozpoczęciaUmowy:��6   $
��Left=�60   $��
56,322,0,0q�6K   $	��Top=�6_   
�������
���   �$��16(�6�   �� 5   
   -   5        $ txtDataRozpoczeciaUpdate��5      $��24��64   $��62,370,72,0q�6@   $
 Wrap=�6U   $	��Top=�6i   $��18(�6�   
���   ����	#FFACACAC6�   �� 5!   
   ���	#FFACACAC$
��Left=�6%   $��54��6@   $��
56,438,0,0q�6L   
���   �$	��Top=�6o   $	��594��6�   �� 5"   
   $��DataZakończeniaUmowy:��6   $
��Left=�60   $��
56,408,0,0q�6K   $	��Top=�6_   
�������
���   �$��16(�6�   $	��187��6�   �� 5#   
   -   5        $ txtDataZakonczeniaUpdate��5#      $��22��64   $��62,456,70,0q�6@   $
 Wrap=�6U   $	��Top=�6i   $��18(�6�   
���   ����	#FFACACAC6�   �� 5%   
   -   5        $��Aktualizuj umowe��5%      $
��Left=�6,   $��232,520,0,0q�6G   $	��Top=�6\   $	��240��6t    J� RenderTransformOrigin$ 	0.487,0.9&�6�   $��40��6�   ���	#FF518B17$��16(�6�   6�   �� 5&   
   -   5        $��Cofnij��5&      $
��Left=�6"   $��232,566,0,0q�6=   $	��Top=�6R   $	��240��6j   $ 	0.487,0.9&�6v   $��40��6�   ���	#FF991D1D$��16(�6�   �� 5(   
   $
��Left=�6   $��
163,80,0,0q�6/   $
��Wrap=�6C   $��Formularz umowy��6W   $	��Top=�6n   $��48(�6�   ���	#FFB22D2D$
��Bold"�6�   5*      5+      