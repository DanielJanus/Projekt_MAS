   M S B A M L   `   `   `  ����L  HMAS-Implementacja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:MAS_Implementacja.ViewsMAS_Implementacja.Views  5   	   .    (MAS_Implementacja.Views.TrainingTypeGrid   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:MAS_Implementacja.Views     5   	     � Title$  TrainingTypeGrid��5   	   $	��960��6"   $
��1600��6/   .��5	      � $	��932��6   $	��Top=�6   $��0,0,0,-3q�60   ��5
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
��Bold"�6�   $��40��6�   $	��116��6�   �� 5   
   -   5        $��DANE OSOBOWE��5      $��35(�6(   $
��Left=�66   $��1222,10,0,0q�6Q   $	��Top=�6f   #��[" �6~   ���#B22D2D$
��Bold"�6�   6�   �� 5   
   -   5        $��NASZE KLUBY��5      $��35(�6'   $
��Left=�65   $��
981,10,0,0q�6P   $	��Top=�6d   #��[" �6|   ���#B22D2D$
��Bold"�6�   6�   �� 5   
   -   5        $��	SZKOLENIA��5      $��35(�6%   $
��Left=�63   $��
781,10,0,0q�6N   $	��Top=�6b   #��[" �6z   ���#B22D2D$
��Bold"�6�    J� RenderTransformOrigin$ -0.195,0.472&�6�   6  �� 5   
   -   5        $��STRONA GŁÓWNA��5      $��35(�6)   $
��Left=�67   $��
463,10,0,0q�6R   $	��Top=�6f   #��[" �6   ���#B22D2D$
��Bold"�6�   6�   �� 5   
   $
��Left=�6   $��75��6+   $��
1518,0,0,0q�67   $	��Top=�6K   $��64��6c   $N��HG:\Users\Daniel\source\repos\MAS-Implementacja\Assets\Universal\User.png��6n   �� 5   
   
���   �$
��Left=�6!   $��44��6<   $��-1,888,-7,0q�6H   
���   �$	��Top=�6l   $
��1920��6�   �� 5   
   $
��Left=�6   $��	9,894,0,0q�6/   $
��Wrap=�6B   $5��/DREAM'SGYM © 2021 Wszystkie prawa zastrzeżone��6V   $	��Top=�6�   ���	#FF514E4E$��15(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ gridTrainingType��5      $
��Left=�6-   $	��678��6H   $��
354,92,0,0q�6U   $	��Top=�6i   $	��850��6�   �� 5   
   -   5        $��Dodaj typ treningu��5      $
��Left=�6.   $��354,805,0,0q�6I   $	��Top=�6^   $	��250��6v   $��63��6�   6�   �� 5   
   -   5        $��Aktualizuj typy��5      $
��Left=�6+   $��954,805,0,0q�6F   $	��Top=�6[   $	��250��6s   $��63��6   6�   �� 5   
   -   5        $��Usuń trening��5      $
��Left=�6(   $��1217,805,0,0q�6C   $	��Top=�6Y   $	��360��6q   $��63��6}   6�   �� 5   
   -	   5        $��Wczytaj typy��5      $
��Left=�6(   $��655,805,0,0q�6C   $	��Top=�6X   $	��250��6p   $��63��6|   6�   �� 5   
   ���	#FFACACAC$
��Left=�6%   $��54��6@   $��1217,716,0,0q�6L   
���   �$	��Top=�6q   $	��360��6�   �� 5   
   -
   5         ��Name$ txtIdTrainingDelete��5      $��22��6/   $��1222,732,21,0q�6;    �� TextWrapping$
 Wrap=�6R   $	��Top=�6f   $��18(�6~   
���   ����	#FFACACAC6�   �� 5   
   $
��Left=�6   $��1217,696,0,0q�6/   $
��Wrap=�6E   $%��Id typu treningu do usunięcia:��6Y   $	��Top=�6   
�������$��16(�6�   �� 5    
   -   5        $��Wróć do treningów��5       $
��Left=�6-   $��	9,805,0,0q�6H   $	��Top=�6[   $	��331��6s   $��63��6   ���	#FFB22D2D$��24(�6�   6�   5#      5$      