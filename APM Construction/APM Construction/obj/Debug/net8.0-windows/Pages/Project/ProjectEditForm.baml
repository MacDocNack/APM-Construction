   M S B A M L   `   `   `  ����K  GAPM Construction, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:APM_Construction.PagesAPM_Construction.Pages  5      ,    &APM_Construction.Pages.ProjectEditForm   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:APM_Construction.Pages     5        N� Title$  ProjectEditForm��5	       N� 
Background
 �����.��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��10q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Project Name:��6   $��16(�60   �� 5      -   5        $��ProjectName��5      $��16(�6/   5      �� 5      $��Budget��6   �� 5      -   5        $��Budget��5       �� 	MaxLength$ 10��6$   63   �� 5      $��Client��6   $��0,10,0,0q�6'   .��5       �  5!      �� 5"      �� 5#      .+�5%      �� .+�5&      �� $��Center=�6%   .+�5'      �� $ 
Horizontal=�6)   .+�5(   "   �� $��Client name:��6(   �� 5)   "   -   5        $��
ClientName��5)   ,   5*      �� 5+      $ 
Horizontal=�6)   .+�5,   "   �� $��Client Phone:��6(   �� 5-   "   -   5        $��ClientPhone��5-   ,   5.      5/      50      51      52      �� 55      $��
Contractor��6   $��0,10,0,0q�6+   .��56      �  57      �� 58      �� 59      .+�5;      �� .+�5<      �� .+�5=      �� $ 
Horizontal=�6)   .+�5>   "   �� $��Client name:��6(   �� 5?   "   -   5        $��ContractorName��5?   ,   5@      �� 5A      $ 
Horizontal=�6)   .+�5B   "   �� $��Contractor phone:��6(   �� 5C   "   -   5        $��ContractorPhone��5C   ,   5D      5E      5F      5G      5H      5I      �� 5K   
   $��Description��6   $��1��6(   $��0��65   $��10q�6E   $	��Top=�6Q   .��5L      �� -   5        $��Description��5L      $	��170��6+   $��WrapWithOverflow=�68   5M      �� 5O   
   $��0��6   $��1��6"   $��2��62   .+�5P      �� .+�5Q      �� $ 
Horizontal=�6   .+�5R      �� $��State��6   �� 5S      -   5        $��	StateList��5S      $��23��60   5T      5U      �� 5V      $ 
Horizontal=�6   .+�5W      �� $��
Date Start��6   �� 5X      -	   5        $��	DateStart��5X      �� 5Y      $��Date End��6   (  "System.Windows.Controls.DatePicker  5Z      -
   5        $��DateEnd��5Z      5[      �� 5^      $��Required resources��6   �� 5_      -   5        $��RequiredResourceList��5_      $	��275��63      RequiredResourceTemplate#��[  6@   �� 5`      $ 
Horizontal=�6   $��Center=�62   .+�5a      �� -   5        $	��Add��5a      $��5q�6'   62   �� 5b      -   5        $��Remove��5b      $��5q�6*   65   �� 5c      -   5        $��Clear��5c      $��5q�6)   64   5d      5e      �� 5f   
   $��1��6   $��1��6"   $��5q�62   $��Bottom=�6=   .+�5g      �� -   5        $��Edit project��5g      $��5q�6@   �� 5h      -   5        $
��Back��5h      $��5q�63   6@   5i      5j      5k      