   M S B A M L   `   `   `  ����
  Carnet    Carnet.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  Mon carnet d'adresse��5   	   $	��350��6&   $	��525��63    � Icon$ 	Icone.ico��5   	   .��5      ]� .+�5   
   o� $	��top=�6   .@�5      m� $��_Fichier��6   .@�5	      m� -   5        $��_Nouveau carnet��5	      64   �� 5
      m� 5      -   5        $��_Enregistrer��5      61   5      m� 5      -   5        $��	_Modifier��5      6*   5      �� 5   
   $	��Top=�6   ���	#FFF0F0F0.+�5      �� 
����������	#FFE6E6E6$��1q�5       �� Padding$ 8q�5      ._�5      � $��Center=�6   .+�5      �� -   5        .��5      �� $��NouvContact.png��6    $��30��69   6F   5      �� 5      -   5        $��10,0,0,0q�5      .��5      �� $��X��6$   $��20(�6-   
���  ��6;   5      �� 5      $.��(           Liste de personne :          ��6    $��Center=�6P   �� 5      -   5        $��laListe��5       �� SelectedIndex$ 0��6.   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6@   $��Center=�6�   6�   5      5      5      � 5!   
    � ColumnDefinitions 5"      �� 5#      �� 5$      .+�5&      �� 
�������$��1q�5'      $ 8q�5(      ���	#FFE6E6E6._�5)      �� .+�5*      �� -   5        $��ImageP��5*      $
��Auto��6*   $
��Auto��67   � 5+       � RowDefinitions 5,      �� 5-      �� 5.       51      �� 52      �� 53      .+�55      �� $��Nom : ��6$   $
��Bold"�62   $��Right=�6D   �� 56      $��
Prénom : ��6$   $��1��65   $
��Bold"�6B   $��Right=�6T   �� 57      -	   5        $��BlockNom��57   $   $��1��64   �� 58      -
   5        $��BlockPrenom��58   $   $��1��67   $��1��6D   5:      5;      5<      �� 5=      
����������	#FFE6E6E6$��1q�5?      $ 8q�5@      $��1��5A      ._�5B      �� .+�5C      � .+�5D      �� $%��Liste numéro Téléphone :    ��6$   $��Center=�6H   $
��Wrap=�6c   �� 5E      -   5        .��5F      �� $��NouvNumero.png��6$   $��30��6<   5G      �� 5H      -   5        $��10,0,0,0q�5H   "   .��5I      �� $��X��6(   $��20(�61   
���  ��6?   5J      5K      �� 5L      -   5        $��listeNum��5L   !   $��0,15,0,0q�61   5M      5N      5O      5P      5Q      