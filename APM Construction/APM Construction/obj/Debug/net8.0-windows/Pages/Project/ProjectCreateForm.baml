   M S B A M L   `   `   `  ����K  GAPM Construction, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:APM_Construction.PagesAPM_Construction.Pages  5      .    (APM_Construction.Pages.ProjectCreateForm   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:APM_Construction.Pages     5        N� Title$  ProjectCreateForm��5	       N� 
Background
 �����.��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��10q�6   .+�5      �� $��Project Name��6   �� 5      -   5        $��ProjectName��5      �� 5      $��Budget��6   �� 5      -   5        $��Budget��5       �� 	MaxLength$ 10��6$   63   �� 5      $��0,10,0,0q�6   .+�5      � .+�5      �� .+�5       ��  �� Orientation$ 
Horizontal=�6%   .+�5!      �� $��Client��6$   �� 5"      -   5        $��
ClientList��5"   '   $	��200��69   $��25��6E      ClientTemplate#���   6Q   5#      �� 5$      -   5        
������ $
��Left=�5$   :   
����  �$��0q�6g   $��
New Client��6{   6�   5%      5&      5'      �� 5*      $��0,10,0,0q�6   .+�5+      � .+�5,      �� .+�5-      �� $ 
Horizontal=�6%   .+�5.      �� $��
Contractor��6$   �� 5/      -   5        $��ContractorList��5/   '   $	��200��6=   $��25��6I     ContractorTemplate#���  6U   50      �� 51      -   5        
������ $
��Left=�51   :   
����  �$��0q�6g   $��New Contractor��6{   6�   52      53      54      55      �� 57   
   $��1��6   $��0��6"   $��10q�62   .+�58      �� $��Description��6   �� 59      -   5        $��Description��59      $	��140��6)   $��16(�66    �� TextWrapping$ WrapWithOverflow=�6D   5:      �� 5<   
   $��0��6   $��1��6"   $��2��62   .+�5=      �� $��0,10,0,0q�6   .+�5>      �� .+�5?      �� $ 
Horizontal=�6!   .+�5@      �� $��State��6    �� 5A      -   5        $��	StateList��5A   #   $��23��64   5B      5C      5D      �� 5E      $��
Date Start��6   (  "System.Windows.Controls.DatePicker  5F      -	   5        $��	DateStart��5F      �� 5G      $��Date End��6     5H      -
   5        $��DateEnd��5H      �� 5I      $��Required resources��6   �� 5J      -   5        $��RequiredResourceList��5J      $	��150��63     RequiredResourceTemplate#���  6@   �� 5K      $ 
Horizontal=�6   $��Center=�62   .+�5L      �� -   5        $	��Add��5L      $��5q�6'   62   �� 5M      -   5        $��Remove��5M      $��5q�6*   65   �� 5N      -   5        $��Clear��5N      $��5q�6)   64   5O      5P      �� 5Q   
   $��1��6   $��1��6"   $��5q�62   $��Bottom=�6=   .+�5R      �� -   5        $��Create project��5R      $��5q�6.   69   �� 5S      -   5        $
��Back��5S      $��5q�63   6@   5T      5U      5V      