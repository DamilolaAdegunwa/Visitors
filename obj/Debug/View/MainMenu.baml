   M S B A M L   `   `   `  ����C  ?Visitors, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Visitors.ViewVisitors.View  5   	       Visitors.View.MainMenu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Visitors.View     5   	   -   5          � Title$  MainMenu��5   	   $��907.196��6   $��1101.643��6+    � WindowStartupLocation$ CenterScreen=�6<    � 
ResizeMode$ NoResize=�6a   .��5	      � -   5         �Name$ EditUserMasterCtrl��5	      $
��Left=�6'   $	��841��6B   $��0,36,0,0q�6O   $	��Top=�6a   $	��187��6y    � ColumnDefinitions 5
   
   �� 5      $
��103* �6   �� 5      $	��84* �6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ 	#FF342C2C��6   $ 1Q�61   5      .+�5   
   � -   5        $
 load��5      $
��Left=�6   $��46��68   $��0,-45,-898,0q�6D   $	��Top=�6Z   $
��1085��6r   $��2��6   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ Black��6#   $ 0Q�61   � 5      $ 	#FF607C89��6#   $ 1Q�65   5      	 � RowDefinitions	 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     5!      �� 5"      $
��Auto �6#   �� 5#      $
��Auto �6#   5%      �� 5&   
   -   5        
 ��Name$
 homeBtn��5&      $
��Left=�6"   $��
21,175,0,0q�6=   $	��Top=�6Q   $	��145��6i   $��45��6u    J� RenderTransformOrigin$ 0.328,0.465&�6�   $��Stencil)�6�   $��16(�6�   $��2��6�   .��5'      �� -   5        $
 homebtn��5'      $
��Home��6&   $��75��65   $��Stencil)�6@   $��16(�6U   $��0q�6c   5(      �� 5)   
   -   5        $
 
AddUserBtn��5)      $
��Left=�6%   $��
21,292,0,0q�6@   $	��Top=�6T   $	��145��6l   $��45��6x   $ 0.328,0.465&�6�   $��Stencil)�6�   $��16(�6�   $��2��6�   .��5*      '   !Visitors.View.EditRoleUserControl  '   !Visitors.View.EditRoleUserControl   Loaded$  EditRoleUserControl_Loaded��6(   5+      �� 5,   
   -   5        $
 EditUserBtn��5,      $��	Edit User��6&   $
��Left=�6:   $��
21,407,0,0q�6U   $	��Top=�6i   $	��145��6�   $��45��6�   $ 0.328,0.465&�6�   $��Stencil)�6�   $��16(�6�   $��2��6�   6�   �� 5-   
   -   5        $
 ViewUserBtn��5-      $��	View User��6&   $
��Left=�6:   $��
21,540,0,0q�6U   $	��Top=�6i   $	��145��6�   $��45��6�   $ 0.328,0.465&�6�   $��Stencil)�6�   $��16(�6�   $��2��6�   6�   �� 5.   
   -	   5        $
 	LogOutBtn��5.      $��Log Out��6$   $
��Left=�66   $��
21,669,0,0q�6Q   $	��Top=�6e   $	��145��6}   $��45��6�   $ 0.328,0.465&�6�   $��Stencil)�6�   $��16(�6�   $��2��6�   6�   !   Visitors.View.InsertUsrCtrl  5/   
   -
   5          Name$ insertUsrCtrl1��5/      $��1��66   $
��Left=�6F   $��84,0,-910,0q�6a   $	��Top=�6v     50   
   -   5          Name$ editroleCtrl1��50   $   $��1��6;   $
��Left=�6K   $��84,1,-910,0q�6f   $	��Top=�6{   53      54      