   M S B A M L   `   `   `  ����L  HMAS-Implementacja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:MAS_Implementacja.ViewsMAS_Implementacja.Views  5   	   1    +MAS_Implementacja.Views.SchoolingUpdateForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:MAS_Implementacja.Views     5   	     � Title$  SchoolingUpdateForm��5   	   $��988.167��6%   $	��714��66   .��5	      � $	��952��6   $	��Top=�6   $��0,0,-8,-223q�60   ��5
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
-1,908,0,0q�6H   
���   �$	��Top=�6k   $	��714��6�   �� 5   
   $
��Left=�6   $��	9,922,0,0q�6/   $
��Wrap=�6B   $5��/DREAM'SGYM © 2021 Wszystkie prawa zastrzeżone��6V   $	��Top=�6�   ���	#FF514E4E$��15(�6�   �� 5   
   
���   �$��center=�6!   $	��740��6>   $��48,144,50,0q�6K   
���   �$	��Top=�6o   $	��616��6�   �� 5   
   ���	#FFACACAC$
��Left=�6%   $��54��6@   $��
56,184,0,0q�6L   
���   �$	��Top=�6o   $	��594��6�   �� 5   
   $��IdSzkolenia:��6   $
��Left=�6'   $��
56,152,0,0q�6B   $	��Top=�6V   
�������
���   �$��16(�6�   �� 5   
   -   5         ��Name$ txtIdSzkoleniaUpdate��5      $��22��60   $��62,200,72,0q�6<    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $��18(�6}   
���   ����	#FFACACAC6�   �� 5   
   ���	#FFACACAC$
��Left=�6%   $��54��6@   $��
56,268,0,0q�6L   
���   �$	��Top=�6o   $	��594��6�   �� 5   
   $��IdInstruktora:��6   $
��Left=�6)   $��
56,238,0,0q�6D   $	��Top=�6X   
�������
���   �$��16(�6�   �� 5   
   -   5        $ txtIdInstruktoraUpdate��5      $��24��62   $��62,286,72,0q�6>   $
 Wrap=�6S   $	��Top=�6g   $��18(�6   
���   ����	#FFACACAC6�   �� 5   
   ���	#FFACACAC$
��Left=�6%   $��54��6@   $��
56,354,0,0q�6L   
���   �$	��Top=�6o   $	��594��6�   �� 5   
   $��Nazwa:��6   $
��Left=�6!   $��
56,322,0,0q�6<   $	��Top=�6P   
�������
���   �$��16(�6�   �� 5    
   -   5        $ txtNazwaUpdate��5       $��24��6*   $��62,370,72,0q�66   $
 Wrap=�6K   $	��Top=�6_   $��18(�6w   
���   ����	#FFACACAC6�   �� 5"   
   ���	#FFACACAC$
��Left=�6%   $��54��6@   $��
56,438,0,0q�6L   
���   �$	��Top=�6o   $	��594��6�   �� 5#   
   $��DataSzkolenia:��6   $
��Left=�6)   $��
56,408,0,0q�6D   $	��Top=�6X   
�������
���   �$��16(�6�   $	��124��6�   �� 5$   
   -   5        $ txtDataSzkoleniaUpdate��5$      $��22��62   $��62,456,70,0q�6>   $
 Wrap=�6S   $	��Top=�6g   $��18(�6   
���   ����	#FFACACAC6�   �� 5&   
   ���	#FFACACAC$
��Left=�6%   $��54��6@   $��
56,524,0,0q�6L   
���   �$	��Top=�6o   $	��594��6�   �� 5'   
   $��IlośćOsób:��6   $
��Left=�6%   $��
56,492,0,0q�6@   $	��Top=�6T   
�������
���   �$��16(�6�   �� 5(   
   -   5        $ txtIloscOsobUpdate��5(      $��24��6.   $��62,540,74,0q�6:   $
 Wrap=�6O   $	��Top=�6c   $��18(�6{   
���   ����	#FFACACAC6�   �� 5*   
   ���	#FFACACAC$
��Left=�6%   $��54��6@   $��
56,608,0,0q�6L   
���   �$	��Top=�6o   $	��594��6�   �� 5+   
   $��Czas trwania:��6   $
��Left=�6(   $��
56,576,0,0q�6C   $	��Top=�6W   
�������
���   �$��16(�6�   �� 5,   
   -   5        $ txtCzasTrwaniaUpdate��5,      $��22��60   $��62,626,74,0q�6<   $
 Wrap=�6Q   $	��Top=�6e   $��18(�6}   
���   ����	#FFACACAC6�   �� 5.   
   ���	#FFACACAC$
��Left=�6%   $��54��6@   $��
56,692,0,0q�6L   
���   �$	��Top=�6o   $	��594��6�   �� 5/   
   $��Koszt:��6   $
��Left=�6!   $��
50,662,0,0q�6<   $	��Top=�6P   
�������
���   �$��16(�6�   �� 50   
   -   5        $ txtKosztUpdate��50      $��22��6*   $��64,708,74,0q�66   $
 Wrap=�6K   $	��Top=�6_   $��18(�6w   
���   ����	#FFACACAC6�   �� 52   
   -   5        $��Aktualizuj szkolenie��52      $
��Left=�60   $��222,771,0,0q�6K   $	��Top=�6`   $	��240��6x    J� RenderTransformOrigin$ 	0.487,0.9&�6�   $��40��6�   ���	#FF518B17$��16(�6�   6�   �� 53   
   -	   5        $��Cofnij��53      $
��Left=�6"   $��222,816,0,0q�6=   $	��Top=�6R   $	��240��6j   $ 	0.487,0.9&�6v   $��40��6�   ���	#FF991D1D$��16(�6�   �� 55   
   $
��Left=�6   $��
129,75,0,0q�6/   $
��Wrap=�6C   $��Formularz szkolenia��6W   $	��Top=�6r   $��48(�6�   ���	#FFB22D2D$
��Bold"�6�   57      58      