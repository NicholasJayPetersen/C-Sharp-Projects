   M S B A M L   `   `   `  ����N  JWPF Test Score List, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WPF_Test_Score_ListWPF_Test_Score_List  5   	   $    WPF_Test_Score_List.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WPF_Test_Score_List     5   	   -   5          �Name$  wndTestScoreList��5   	    � Title$ Test Score List��5   	   $	��450��6!   $	��800��6.   $��18(�6:   .��5	      � .+�5
   
   �� -   5         ��Name$ tabScoreList��5
      $
��Left=�6+   $	��364��6F   $��	19,10,0,0q�6S   $	��Top=�6f   $	��752��6~   $��2��6�   .@�5      �� -   5         ��Name$ 	tabScores��5      $��S_cores��6)   .��5      � ���	#FFE5E5E5 � ColumnDefinitions 5      �� 5      $��32 �6+   �� 5      $	��11* �6+   �� 5      $
��703* �6+   .+�5      �� -   5         ��Name$ 	lstScores��5      $
��Left=�61   $	��232��6L   $��4,43,0,0q�6Y   $	��Top=�6k   $	��223��6�   $��1��6�   $��2��6�   �� 5      -   5         ��Name$ txtScore��5      $
��Left=�60   $��29��6K   $��
472,99,0,0q�6W    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��175��6�   $��2��6�   �� 5      $"��Enter test score (0 to 100):��6   $
��Left=�6C   $��29��6^   $��
231,99,0,0q�6j   $	��Top=�6~   $	��222��6�   $��2��6�    �� Target 6�   �� 	 �� ElementName$	 txtScore��
 �� Mode$
 OneWay=�6�   �� 5      -   5         ��Name$ btnEnterScore��5      $��_Enter Score��64   $
��Left=�6K   $��30��6f   $��472,142,0,0q�6r   $	��Top=�6�   $	��138��6�   $��2��6�   �� 5      -   5        $ btnRemoveScore��5      $��_Remove Score��65   $
��Left=�6M   $��30��6h   $��
33,280,0,0q�6t   $	��Top=�6�   $	��138��6�   $��2��6�   5      5      �� 5      -   5        $ 
tabResults��5      $��_Results��6*   ${�False��6<   .��5      � ���	#FFE5E5E5.+�5      �� $��Average score:��6   $
��Left=�65   $��35��6P   $��	48,56,0,0q�6\   $	��Top=�6o   $	��131��6�   �� 5      $%��Number of scores above average:��6   $
��Left=�6F   $��35��6a   $��	48,96,0,0q�6m   $	��Top=�6�   $	��281��6�   �� 5      $%��Number of scores below average:��6   $
��Left=�6F   $��35��6a   $��
48,136,0,0q�6m   $	��Top=�6�   $	��281��6�   �� 5      $��Highest test score:��6   $
��Left=�6:   $��35��6U   $��
48,180,0,0q�6a   $	��Top=�6u   $	��281��6�   �� 5      $��Lowest test score:��6   $
��Left=�69   $��35��6T   $��
48,220,0,0q�6`   $	��Top=�6t   $	��281��6�   �� 5       -	   5         ��Name$ lblAverageScore��5       $�� ��65   $
��Left=�6@   $��35��6[   $��
334,56,0,0q�6g   $	��Top=�6{   $	��105��6�   
���   �$��1q�6�   $��Right=�6�   �� 5!      -
   5        $ lblCountAboveAverage��5!      $�� ��6:   $
��Left=�6E   $��35��6`   $��
334,96,0,0q�6l   $	��Top=�6�   $	��105��6�   
���   �$��1q�6�   $��Right=�6�   �� 5"      -   5        $ lblCountBelowAverage��5"      $�� ��6:   $
��Left=�6E   $��35��6`   $��334,136,0,0q�6l   $	��Top=�6�   $	��105��6�   
���   �$��1q�6�   $��Right=�6�   �� 5#      -   5        $ lblHighestScore��5#      $�� ��65   $
��Left=�6@   $��35��6[   $��334,180,0,0q�6g   $	��Top=�6|   $	��105��6�   
���   �$��1q�6�   $��Right=�6�   �� 5$      -   5        $ lblLowestScore��5$      $�� ��64   $
��Left=�6?   $��35��6Z   $��334,220,0,0q�6f   $	��Top=�6{   $	��105��6�   
���   �$��1q�6�   $��Right=�6�   5%      5&      5'      5)      5*      