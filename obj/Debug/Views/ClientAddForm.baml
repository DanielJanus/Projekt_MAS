   M S B A M L   `   `   `  ����L  HMAS-Implementacja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:MAS_Implementacja.ViewsMAS_Implementacja.Views  5   	   +    %MAS_Implementacja.Views.ClientAddForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:MAS_Implementacja.Views     5   	     � Title$  ClientAddForm��5   	   $��1229.333��6    $	��714��62   .��5	      � $
��1202��6   $	��Top=�6   $��	0,0,-8,-4q�61   ��5
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
��Left=�6!   $��44��6<   $��
0,1156,0,0q�6H   
���   �$	��Top=�6k   $	��714��6�   �� 5   
   $
��Left=�6   $��10,1166,0,0q�6/   $
��Wrap=�6D   $5��/DREAM'SGYM © 2021 Wszystkie prawa zastrzeżone��6X   $	��Top=�6�   ���	#FF514E4E$��15(�6�   �� 5   
   
���   �$��center=�6!   $	��984��6>   $��48,144,50,0q�6K   
���   �$	��Top=�6o   $	��616��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5       �� AngleX$ 0.036Q�6$   �� 5      T� 5       T� X$ 0.499Q�6)   5      5      �� 5   
   $
��Left=�6   $��
179,86,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��40(�6o   ���	#FFB22D2D$
��Bold"�6�   $��Formularz klienta��6�   �� 5   
   ���	#FFACACAC$
��Left=�6%   $��54��6@   $��
56,183,0,0q�6L   
���   �$	��Top=�6o   $	��594��6�   �� 5   
   $��Imie:��6   $
��Left=�6    $��
56,151,0,0q�6;   $	��Top=�6O   
�������
���   �$��16(�6�   �� 5    
   -   5         ��Name$ txtImie��5       $��24��6#   $��62,199,72,0q�6/    �� TextWrapping$
 Wrap=�6D   $	��Top=�6X   $��18(�6p   
���   ����	#FFACACAC6�   �� 5!   
   ���	#FFACACAC$
��Left=�6%   $��54��6@   $��
56,267,0,0q�6L   
���   �$	��Top=�6o   $	��594��6�   �� 5"   
   $��	Nazwisko:��6   $
��Left=�6$   $��
56,237,0,0q�6?   $	��Top=�6S   
�������
���   �$��16(�6�   $	��191��6�   �� 5#   
   -   5        $ txtNazwisko��5#      $��22��6'   $��62,285,70,0q�63   $
 Wrap=�6H   $	��Top=�6\   $��18(�6t   
���   ����	#FFACACAC6�   �� 5$   
   ���	#FFACACAC$
��Left=�6%   $��54��6@   $��
56,353,0,0q�6L   
���   �$	��Top=�6o   $	��594��6�   �� 5%   
   $��DataUrodzenia:��6   $
��Left=�6)   $��
56,321,0,0q�6D   $	��Top=�6X   
�������
���   �$��16(�6�   �� 5&   
   -   5        $ txtDataUrodzenia��5&      $��24��6,   $��62,369,74,0q�68   $
 Wrap=�6M   $	��Top=�6a   $��18(�6y   
���   ����	#FFACACAC6�   �� 5'   
   ���	#FFACACAC$
��Left=�6%   $��54��6@   $��
58,438,0,0q�6L   
���   �$	��Top=�6o   $	��594��6�   �� 5(   
   $��AdresEmail:��6   $
��Left=�6&   $��
58,406,0,0q�6A   $	��Top=�6U   
�������
���   �$��16(�6�   �� 5)   
   -   5        $ txtAdresEmail��5)      $��24��6)   $��64,454,70,0q�65   $
 Wrap=�6J   $	��Top=�6^   $��18(�6v   
���   ����	#FFACACAC6�   �� 5*   
   ���	#FFACACAC$
��Left=�6%   $��54��6@   $��
58,522,0,0q�6L   
���   �$	��Top=�6o   $	��594��6�   �� 5+   
   $��TelefonKontaktowy:��6   $
��Left=�6-   $��
58,492,0,0q�6H   $	��Top=�6\   
�������
���   �$��16(�6�   $	��191��6�   �� 5,   
   -   5        $ 
txtTelefon��5,      $��22��6&   $��64,540,68,0q�62   $
 Wrap=�6G   $	��Top=�6[   $��18(�6s   
���   ����	#FFACACAC6�   �� 5-   
   ���	#FFACACAC$
��Left=�6%   $��54��6@   $��
58,608,0,0q�6L   
���   �$	��Top=�6o   $	��594��6�   �� 5.   
   $��AdresZamieszkania:��6   $
��Left=�6-   $��
58,576,0,0q�6H   $	��Top=�6\   
�������
���   �$��16(�6�   �� 5/   
   -   5        $ txtAdresZamieszkania��5/      $��24��60   $��64,624,72,0q�6<   $
 Wrap=�6Q   $	��Top=�6e   $��18(�6}   
���   ����	#FFACACAC6�   �� 50   
   ���	#FFACACAC$
��Left=�6%   $��54��6@   $��
58,689,0,0q�6L   
���   �$	��Top=�6o   $	��594��6�   �� 51   
   $��Pesel:��6   $
��Left=�6!   $��
62,662,0,0q�6<   $	��Top=�6P   
�������
���   �$��16(�6�   $��27��6�   �� 52   
   -   5        $ txtPesel��52      $��24��6$   $��64,705,70,0q�60   $
 Wrap=�6E   $	��Top=�6Y   $��18(�6q   
���   ����	#FFACACAC6�   �� 53   
   ���	#FFACACAC$
��Left=�6%   $��54��6@   $��
58,779,0,0q�6L   
���   �$	��Top=�6o   $	��594��6�   �� 54   
   $ ��RodzajDokumentuOsobistego:��6   $
��Left=�65   $��
58,747,0,0q�6P   $	��Top=�6d   
�������
���   �$��16(�6�   �� 55   
   -   5        $ txtRodzajDokumentu��55      $��24��6.   $��64,795,70,0q�6:   $
 Wrap=�6O   $	��Top=�6c   $��18(�6{   
���   ����	#FFACACAC6�   �� 57   
   ���	#FFACACAC$
��Left=�6%   $��54��6@   $��
58,863,0,0q�6L   
���   �$	��Top=�6o   $	��594��6�   �� 58   
   $��ZaświadczenieOdLekarza:��6   $
��Left=�62   $��
58,833,0,0q�6M   $	��Top=�6a   
�������
���   �$��16(�6�   $	��191��6�   �� 59   
   -	   5        $ txtZaswiadczenie��59      $��22��6,   $��64,881,68,0q�68   $
 Wrap=�6M   $	��Top=�6a   $��18(�6y   
���   ����	#FFACACAC6�   �� 5;   
   ���	#FFACACAC$
��Left=�6%   $��54��6@   $��
58,949,0,0q�6L   
���   �$	��Top=�6o   $	��594��6�   �� 5<   
   $%��ZgodaDotyczącaRegulaminuKlubu:��6   $
��Left=�69   $��
58,917,0,0q�6T   $	��Top=�6h   
�������
���   �$��16(�6�   �� 5=   
   -
   5        $ txtZgoda��5=      $��24��6$   $��64,965,72,0q�60   $
 Wrap=�6E   $	��Top=�6Y   $��18(�6q   
���   ����	#FFACACAC6�   �� 5?   
   -   5        $��Dodaj klienta��5?      $
��Left=�6)   $��234,1020,0,0q�6D   $	��Top=�6Z   $	��240��6r   $ 	0.487,0.9&�6~   $��40��6�   ���	#FF518B17$��16(�6�   6�   �� 5@   
   -   5        $��Cofnij��5@      $
��Left=�6"   $��234,1066,0,0q�6=   $	��Top=�6S   $	��240��6k   $ 	0.487,0.9&�6w   $��40��6�   ���	#FF991D1D$��16(�6�   6�   5C      5D      