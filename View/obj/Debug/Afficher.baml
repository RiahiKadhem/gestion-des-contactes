   M S B A M L   `   `   `  ����?  ;View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ViewView  5   	       View.Afficher   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:View     5   	     � Title$  Afficher��5   	   $��396.4��6   $��573.5��6)   .��5	      � .+�5
   
   �� $��Affichage des contacts��6   $
��Left=�61   $��	178,3,0,0q�6L   $	��Top=�6_   $	��230��6w   $��42��6�   $
��Bold"�6�   $��20(�6�   �� 5   
   $��Recherche par nom :��6   $
��Left=�6.   $��	10,65,0,0q�6I   $	��Top=�6\   $��32��6t   �� 5   
   $+��%Recherche par 
numero de telephone :��6   $
��Left=�6H   $��
10,103,0,0q�6c   $	��Top=�6w   $��52��6�   �� 5   
   -   5         ��Name$	 txt��5      $
��Left=�6   $��28��6:   $��150,167,0,0q�6F    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��120��6�   �� 5   
   -   5         ��Name$ champ��5      $
��Left=�6"   $��150,215,0,0q�6=   $	��Top=�6R   $	��120��6j   $��27��6�   .@�5      ��  �� 
IsSelected . .��6-   $"selectionner un type de groupement6Q   �� 5      .��6   Name6!   �� 5      .��6   Prenom6#   �� 5      .��6   Groupe6#   5      �� 5   
   $��grouper par :��6   $
��Left=�6(   $��
10,215,0,0q�6C   $	��Top=�6W   $��47��6o   �� 5   
   $��trier par nom :��6   $
��Left=�6*   $��
10,268,0,0q�6E   $	��Top=�6Y   $��32��6q   	� 5   
   -   5        $	��oui��5       	� 	GroupName$	 tri��6"   $
��Left=�62   $��150,275,0,0q�6M   $	��Top=�6b   $��19��6z   .��6�   Oui5      	� 5   
   -   5        $	��non��5      $	 tri��6!   $
��Left=�61   $��202,275,0,0q�6L   $	��Top=�6a   $��19��6y    d� 	IsChecked$
 TrueY�6�   .��6�   Non5      �� 5   
   -   5        $��afficher��5      $��Afficher��6!   $
��Left=�64   $��282,328,0,0q�6O   $	��Top=�6d   $��75��6|   6�   �� 5   
   -   5        $��afficher_tout��5      $��Afficher tout��6&   $
��Left=�6>   $��374,328,0,0q�6Y   $	��Top=�6n   $��75��6�   6�   �� 5    
   -   5        $��retour��5       $��Retour��6   $
��Left=�60   $��466,328,0,0q�6K   $	��Top=�6`   $��75��6x   6�   �� 5!   
   $��Recherche :��6   $
��Left=�6&   $��
15,167,0,0q�6A   $	��Top=�6U   $��90��6m   $��33��6x   �� 5"   
   -   5        $��	affichage��5"   $    �� 
IsReadOnly . $
��Left=�65   $��
329,65,0,0q�6P   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��235��6�   $	��212��6�   " �� VerticalScrollBarVisibility$ Visible=�6�   	� 5#   
   -	   5        $
��rnom��5#      $ search��6"   $�� ��65   $
��Left=�6@   $��
150,71,0,0q�6[   $	��Top=�6o   $
 trueY�6�   	� 5$   
   -
   5        $
��rtel��5$      $ search��6"   $�� ��65   $
��Left=�6@   $��150,123,0,0q�6[   $	��Top=�6p   5'      5(      