   M S B A M L   `   `   `  ����L  HMAS-Implementacja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:MAS_Implementacja.ViewsMAS_Implementacja.Views  5   	   /    )MAS_Implementacja.Views.TrainerUpdateForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:MAS_Implementacja.Views     5   	     � Title$  TrainerUpdateForm��5   	   $��733.167��6#   $	��714��64   .��5	      � $	��706��6   $	��Top=�6   $��	0,0,-8,-4q�60   ��5
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
   $��
IdTrenera:��6   $
��Left=�6%   $��
56,152,0,0q�6@   $	��Top=�6T   
�������
���   �$��16(�6�   �� 5   
   -   5         ��Name$ txtIdTreneraUpdate��5      $��22��6.   $��62,200,72,0q�6:    �� TextWrapping$
 Wrap=�6O   $	��Top=�6c   $��18(�6{   
���   ����	#FFACACAC6�   �� 5   
   ���	#FFACACAC$
��Left=�6%   $��54��6@   $��
56,268,0,0q�6L   
���   �$	��Top=�6o   $	��594��6�   �� 5   
   $��IdPracownik:��6   $
��Left=�6'   $��
56,238,0,0q�6B   $	��Top=�6V   
�������
���   �$��16(�6�   �� 5   
   -   5        $ txtIdPracownikUpdate��5      $��24��60   $��62,286,72,0q�6<   $
 Wrap=�6Q   $	��Top=�6e   $��18(�6}   
���   ����	#FFACACAC6�   �� 5   
   ���	#FFACACAC$
��Left=�6%   $��54��6@   $��
56,354,0,0q�6L   
���   �$	��Top=�6o   $	��594��6�   �� 5   
   $��OferowaneTreningi:��6   $
��Left=�6-   $��
56,322,0,0q�6H   $	��Top=�6\   
�������
���   �$��16(�6�   �� 5    
   -   5        $  txtOferowaneTreningiUpdate��5       $��24��66   $��62,370,72,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $��18(�6�   
���   ����	#FFACACAC6�   �� 5"   
   ���	#FFACACAC$
��Left=�6%   $��54��6@   $��
56,438,0,0q�6L   
���   �$	��Top=�6o   $	��594��6�   �� 5#   
   $��PrawoWykonywaniaZawodu:��6   $
��Left=�62   $��
56,408,0,0q�6M   $	��Top=�6a   
�������
���   �$��16(�6�   $	��213��6�   �� 5$   
   -   5        $ txtPrawoUpdate��5$      $��22��6*   $��62,456,70,0q�66   $
 Wrap=�6K   $	��Top=�6_   $��18(�6w   
���   ����	#FFACACAC6�   �� 5&   
   -   5        $��Zaktualizowano trenera��5&      $
��Left=�62   $��232,520,0,0q�6M   $	��Top=�6b   $	��240��6z    J� RenderTransformOrigin$ 	0.487,0.9&�6�   $��40��6�   ���	#FF518B17$��16(�6�   6�   �� 5'   
   -   5        $��Cofnij��5'      $
��Left=�6"   $��232,566,0,0q�6=   $	��Top=�6R   $	��240��6j   $ 	0.487,0.9&�6v   $��40��6�   ���	#FF991D1D$��16(�6�   �� 5)   
   $
��Left=�6   $��
163,80,0,0q�6/   $
��Wrap=�6C   $��Formularz trenera��6W   $	��Top=�6p   $��48(�6�   ���	#FFB22D2D$
��Bold"�6�   5+      5,      