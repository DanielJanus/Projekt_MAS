   M S B A M L   `   `   `  ����L  HMAS-Implementacja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:MAS_Implementacja.ViewsMAS_Implementacja.Views  5   	   )    #MAS_Implementacja.Views.OfferWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:MAS_Implementacja.Views     5   	     � Title$  OfferWindow��5   	   $��875.833��6   $��1366.5��6.   .��5	      � $	��Top=�6   $��	0,0,0,-31q�6#    � RowDefinitions 5
   
   �� 5      $
��523* �6   �� 5      $
��427* �6   ��5   
   �� 5       �� ImageSource$T NG:\Users\Daniel\source\repos\MAS-Implementacja\Assets\Universal\Background.png��6   .+�5   
   �� $��Center=�6   $��75��61   
���   �
���   �$	��Top=�6Y   $
��1358��6q   �� 5   
   $��DREAM'S��6   $��50(�6#   $
��Left=�61   $��	-1,-4,0,0q�6L   $	��Top=�6_   #��[" �6w   ���#B22D2D$
��Bold"�6�   �� 5   
   $	��GYM��6   $��25(�6   $
��Left=�6-   $��
196,23,0,0q�6H   $	��Top=�6\   #��[" �6t   
�������$
��Bold"�6�   $��40��6�   $	��116��6�   �� 5   
   -   5        $��STRONA GŁÓWNA��5      $��35(�6)   $
��Left=�67   $��
957,10,0,0q�6R   $	��Top=�6f   #��[" �6   ���#B22D2D$
��Bold"�6�   6�   �� 5   
   
���   �$
��Left=�6!   $	��598��6<   $��
44,169,0,0q�6I   
���   �$	��Top=�6l   $
��1272��6�   $��2��6�   �� 5   
   $��Center=�6   $	��225��61   $��113,243,923,0q�6>   
���   �$	��Top=�6d   $	��322��6|   ��5      �� 5      $Q KG:\Users\Daniel\source\repos\MAS-Implementacja\Assets\Main\OfferReduced.png��6   6y   5      �� 5   
   $��Center=�6   $	��225��61   $��522,243,514,0q�6>   
���   �$	��Top=�6d   $	��322��6|   ��5      �� 5      $Q KG:\Users\Daniel\source\repos\MAS-Implementacja\Assets\Main\OfferStudent.png��6   6y   5!      �� 5#   
   $��Center=�6   $	��224��61   $��923,244,113,0q�6>   
���   �$	��Top=�6d   $	��322��6|   ��5$      �� 5%      $P JG:\Users\Daniel\source\repos\MAS-Implementacja\Assets\Main\OfferNormal.png��6   6x   5'      �� 5)   
   $
��Left=�6   $��75��6+   $��
1284,0,0,0q�67   $	��Top=�6K   $��64��6c   $N��HG:\Users\Daniel\source\repos\MAS-Implementacja\Assets\Universal\User.png��6n   �� 5*   
   
���   �$
��Left=�6!   $��44��6<   $��	0,344,0,0q�6H   
���   �$	��Top=�6j   $
��1358��6�   $��1��6�   �� 5+   
   $
��Left=�6   $��
10,350,0,0q�6/   $
��Wrap=�6C   $5��/DREAM'SGYM © 2021 Wszystkie prawa zastrzeżone��6W   $	��Top=�6�   ���	#FF514E4E$��15(�6�   $��1��6�   �� 5.   
   -   5        $��Karnet ulgowy��5.      $
��Left=�6)   $��196,206,0,0q�6D   $	��Top=�6Y   $	��138��6q   $��30��6}   $��1��6�   ���	#FF518B176�   �� 5/   
   -   5        $��Karnet studencki��5/      $
��Left=�6,   $��608,206,0,0q�6G   $	��Top=�6\   $	��138��6t   $��30��6�   $��1��6�   ���	#FF518B176�   �� 50   
   -   5        $��Karnet normalny��50      $
��Left=�6+   $��1013,206,0,0q�6F   $	��Top=�6\   $	��138��6t   $��30��6�   $��1��6�   ���	#FF518B176�   �� 51   
   -   5        $ ��Wróć na strone główną��51      $
��Left=�61   $��608,248,0,0q�6L   $	��Top=�6a   $	��138��6y   $��30��6�   $��1��6�   ���	#FF991D1D6�   �� 54   
   $
��Left=�6   $��
462,89,0,0q�6/   $
��Wrap=�6C   $��Oferta dla klientów��6W   $	��Top=�6r   ���	#FFB22D2D$��50(�6�    J� RenderTransformOrigin$ 0.506,0.142&�6�   $
��Bold"�6�   �� 55   
   $
��Left=�6   $	��197��6/   $��113,468,0,0q�6<   
���   ����	#FFACACAC$	��Top=�6q   $	��316��6�   $��2��6�   6�   �� 56   
   $
��Left=�6   $	��197��6/   $��522,468,0,0q�6<   
���   ����	#FFACACAC$	��Top=�6q   $	��316��6�   $��2��6�   6�   �� 57   
   $
��Left=�6   $	��197��6/   $��923,468,0,0q�6<   
���   ����	#FFACACAC$	��Top=�6q   $	��316��6�   $��2��6�   6�   �� 58   
   $
��Left=�6   $��	122,5,0,0q�6/   $
��Wrap=�6B   $����Karnet ulgowy – przysługuje: uczniom od lat 16 do lat 19 (za każdorazowym okazaniem legitymacji szkolnej), rencistom, emerytom (za każdorazowym okazaniem legitymacji),  kombatantom (za każdorazowym okazaniem legitymacji), osobom niepełnosprawnym z orzeczonym znacznym lub umiarkowanym stopniem niepełnosprawności (za każdorazowym okazaniem legitymacji).��6V   $	��Top=�6�  $	��192��6�  $	��296��6�  
���   �$��14(�6  $��1��6  �� 59   
   $
��Left=�6   $��	531,5,0,0q�6/   $
��Wrap=�6B   $����Karnet dla studentów / doktorantów – przysługuje studentom i doktorantom z ważną legitymacją, decydujesz kiedy karnet ma być aktywny, ćwiczysz ile chcesz, masz dostęp do najlepszych klubów fitness w Polsce oraz nie podpisujesz żadnych umów.��6V   $	��Top=�6N  $	��192��6f  $	��296��6s  
���   �$��14(�6�  $��1��6�  �� 5:   
   $
��Left=�6   $��
934,10,0,0q�6/   $
��Wrap=�6C   $����Karnet normalny – przysługuje: osobom chcącym zapisać się na siłownie ale nie spełniają wymogów do innego rodzaju karnetu. Zawiera w sobie trening wprowadzający i stała opieka trenerki nielimitowany dostęp do zajęć fitness nielimitowany dostęp do siłowni comiesięczna wizyta dietetyczna stała opieka trenerki wprowadzającej wraz z pomiarami i analizą.��6W   $	��Top=�6�  $	��192��6�  $	��296��6�  
���   �$��14(�6  $��1��6  5=      5>      