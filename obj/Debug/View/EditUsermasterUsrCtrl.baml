   M S B A M L   `   `   `  ����C  ?Visitors, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Visitors.ViewVisitors.View  5      '    !Visitors.View.EditRoleUserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      q mTelerik.Windows.Controls.ImageEditor, Version=2018.2.620.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2018.2.620.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2018.2.620.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7m iTelerik.Windows.Controls.Docking, Version=2018.2.620.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q	 mTelerik.Windows.Controls.FileDialogs, Version=2018.2.620.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n
 jTelerik.Windows.Controls.GridView, Version=2018.2.620.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2018.2.620.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j fTelerik.Windows.Controls.Data, Version=2018.2.620.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Mtelerik1http://schemas.telerik.com/2008/xaml/presentation     	 
   5      5localclr-namespace:Visitors.View     	 
   5      $	��836��5       $	��910��6-   ��5
      �� 5   
     �� ImageSource$1  +C:\Users\30692\Documents\Telerik\laptop.jpg��6    j� Stretch$
 Fill=�6O   .��5      �� .+�5   
   �� -   5         ��Name$ editUserLbl��5      $��	Edit User��6%    �� Left$	 409��69   
 �� Top$	 204��6K   $��Stencil)�6\   $��24(�6q   ���	#FFE0E0E06   �� 5   
   -   5        $ Username��5      $��	User name��6"   $	 222��66   $	 336��6H   $��Stencil)�6Y   $��16(�6n   ���	#FFE0E0E06|   �� 5   
   -   5         ��Name$ UserNameTxt��5      $��23��6'   $	 428��63    �� TextWrapping$
 Wrap=�6E   $	 336��6Z   $	��120��6k   (  "Telerik.Windows.Controls.RadButton  5   
   -   5          Name$ searchUserNameBtn��5   .      CornerRadius$ 15��6   $��Search��6I   $	 586��6Z   $	 336��6l   $��75��6}   $��Stencil)�6�   $��16(�6�   $��29��6�   6�     5   
   -   5        $ searchRoleNameBtn��5   .   $ 15��6   $��Search��6I   $	 586��6Z   $	 407��6l   $��75��6}   $��Stencil)�6�   $��16(�6�   $��29��6�   6�   �� 5   
   -   5        $ ByRolenameLbl��5      $��	Role Name��6'   $	 222��6;   $	 413��6M   $��Stencil)�6^   $��16(�6s   ���	#FFE0E0E06�   �� 5   
   -   5        $ roleNameTxt��5      $��23��6'   $	 428��63   $
 Wrap=�6E   $��
��6Y   $	 413��6f   $	��120��6w   	 J� RenderTransformOrigin$	 
0.55,0.609&�6�     5   
   -   5        $ 
FindAllBtn��5   .   $ 15��6   $��Find All��6B   $	 434��6U   $	 478��6g   $��75��6x   $��Stencil)�6�   $��16(�6�   $��33��6�   $	 0.5,0.5&�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -	   5        
  Name$
 dataGridUser��5      $ 83��6)   $	 548��6:   $��96��6K   $	��771��6W   5      5      5      