   M S B A M L   `   `   `  ����C  ?workbase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:workbaseworkbase  5   	       workbase.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:workbase     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��82* �6   �� 5      $
��117* �6   �� 5      $
��594* �6   .+�5   
   o� $��28��6   $	��Top=�6   $��3��63   $��0,0,4,0q�6G   .@�5      m� $
��File��6   $��0,-2,4,3q�5      $��18(�5      $��30��5      $��61��6#    m� Icon 5      �� 5      $��Resources/menu.png��6   $��1,1,1,1q�68    J� RenderTransformOrigin$ 0.923,0.808&�6I   .@�5      m� -   5        $��Сохранить как��5      5      �� 5      m� 5      -   5        $��
Выйти��5      5      5      5      c� 5   
   $��0,26,39.5,0q�6   $��28��6(   $	��Top=�64   $ 0.5,0.5&�6L   .@�5       d� -   5        .��5!      �� $��Resources/more.png��6   $��18��64   $��14��6@   5"      �� 5#      �� 5$      -   5        .��5%      �� $��Resources/filter.png��6   $��18��66   $��28��6B   5&      �� 5'      5(      �� 5)   
   $��0��6   $��	-1,59,1,0q�5*       �� Orientation$ Vertical=�5+      $	��Top=�5,      $��2��6-   .+�5-      �� -   5        $��BtnPrint��5-      $	��130��5.      $��30��5/      $)��#Список сотрудников��50      $��5q�51      52      �� 53      $%��Поиск по фамилии:��6   $	��130��54      $��20��55      $��5q�56      �� 57      -   5        $��	TxtSearch��59      $	��130��57      $��30��58      5:      �� 5;      -   5        $��BtnOpen��5;      $	��130��5=      $��30��5>      $��Открыть��5?      $��5q�5@      �� 5A      $@��:Среднее значение общего оклада:��6   $��20��5B      $��2,5,5,5q�5C      �� 5D      -   5        $��TxtCount��5F      $	��130��5D      $��30��5E      5F      �� 5G      -	   5        $��MenuItem��5G      $	��130��5I      $��30��5J      $��Посчитать��5K      $��5q�5L      5N      �� 5P   
   $ Vertical=�6   $	��Top=�5Q      $��2��5R      .+�5S      &   System.Windows.Controls.DataGrid  -
   5        $��DtgListWorking��5S         
IsReadOnly . $��5q�5U         AutoGenerateColumns .     Columns 5W      0  *System.Windows.Controls.DataGridTextColumn  5X      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��5Y      	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6*   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 5Z      �� *Name+  5[      $ Год рождения��5\      $	 * 6/   
 5]      �� *
Birth_year+  5^      $ 
Оклад��5_      $	 * 6(   
 5`      �� *Pay+4  .System.Windows.Controls.DataGridTemplateColumn  5a         CellTemplate 5b      �� 5c      .R�5d   "   �� $ 
Horizontal=�6-   $��Center=�5e   -   .+�5g   &   �� $��	BtnDelete��5j   %   -   5        $��5q�5h   %   $	��100��5i   %   $��Удалить��5l   %   5m   #   5o      5q      5s      5u      5v      5w      