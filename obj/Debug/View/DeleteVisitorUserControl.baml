   M S B A M L   `   `   `  ����C  ?Visitors, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Visitors.ViewVisitors.View  5      ,    &Visitors.View.DeleteVisitorUserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      q mTelerik.Windows.Controls.ImageEditor, Version=2018.2.620.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2018.2.620.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2018.2.620.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7m iTelerik.Windows.Controls.Docking, Version=2018.2.620.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q	 mTelerik.Windows.Controls.FileDialogs, Version=2018.2.620.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n
 jTelerik.Windows.Controls.GridView, Version=2018.2.620.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2018.2.620.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j fTelerik.Windows.Controls.Data, Version=2018.2.620.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Mtelerik1http://schemas.telerik.com/2008/xaml/presentation     	 
   5      5localclr-namespace:Visitors.View     	 
   5      $	��836��5      $	��910��6,   $��Stretch=�68   $��Stretch=�6V   ��5
      �� 5   
     �� ImageSource$1  +C:\Users\30692\Documents\Telerik\laptop.jpg��6    j� Stretch$
 Fill=�6O   .��5      � .+�5   
   �� -   5         ��Name$ DeleteVisitorLbl��5      $��Delete User��6*   $
��Left=�6@   $��
363,38,0,0q�6[   $	��Top=�6o   $��Stencil)�6�   $
��24px(�6�   ���	#FFE0E0E06�   �� 5   
   -   5        $ UserNameLbl��5      $��	User Name��6%   $
��Left=�69   $��270,174,0,0q�6T   $	��Top=�6i   $	��108��6�   $��Stencil)�6�   $��16(�6�   ���	#FFE0E0E06�   �� 5   
   -   5         ��Name$ UserNameTxt��5      $
��Left=�6'   $��23��6B    �� TextWrapping$
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��169��6�   $��393,174,0,0q�6�   (  "Telerik.Windows.Controls.RadButton  5   
   -   5          Name$ searchUserNameBtn��5   /      CornerRadius$ 15��6   $��Search��6J    �� Left$	 586��6[   
 �� Top$	 336��6m   $��75��6~   $��Stencil)�6�   $��16(�6�   $��29��6�   $��581,152,254,655q�6�   �� 5   
   -   5        	 ��Name$	 	textBlock��5      $
��Left=�6'   $��0��6B   $��462,432,0,0q�6M   $
��Wrap=�6b   $��	TextBlock��6v   $	��Top=�6�   $��8��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        
  Name$
 dataGridUser��5      $ 83��6)   $	 548��6:   $	��771��6K   $��65,271,74,436q�6X      
IsReadOnly . 6o     5   
   -   5        $ 	deleteBtn��5   /   $ 15��6   $��Delete��6C   $��Stencil)�6T   $��16(�6i   $
��Left=�6x   $��404,229,0,0q�6�   $	��Top=�6�   $��75��6�   $y�Hidden=�6�     5   
   -   5        $ 
FindAllBtn��5   /   $ 15��6   $��Find All��6C   $��16(�6V   $
��Left=�6d   $��404,214,0,0q�6   $	��Top=�6�   $��95��6�   $��40��6�   5      5      