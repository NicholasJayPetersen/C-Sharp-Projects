   M S B A M L   `   `   `  ����V  RWPF Future Value - Complete, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:WPF_Future_Value___CompleteWPF_Future_Value___Complete  5   	   ,    &WPF_Future_Value___Complete.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:WPF_Future_Value___Complete     5   	   -   5          �Name$  wndFutureValue��5   	    � Title$ Future Value��5   	   $	��450��6   $	��800��6+   .��5	      � .+�5
   
   �� -   5         ��Name$ txtMonthlyInvestment��5
      $
��Left=�60   $��37��6K   $��
389,30,0,0q�6W    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��289��6�   �� 5   
   $��_Montly investment:��6   $
��Left=�6.   $��37��6I   $��
125,30,0,0q�6U   $	��Top=�6i   $	��242��6�    �� Target 6�   ��  �� ElementName$ txtMonthlyInvestment�� �� Mode$ OneWay=��� 5   
   -   5        $ txtInterestRate��5      $
��Left=�6+   $��37��6F   $��
389,92,0,0q�6R   $
 Wrap=�6f   $	��Top=�6z   $	��289��6�   �� 5   
   $��_Interest rate:��6   $
��Left=�6*   $��37��6E   $��
125,92,0,0q�6Q   $	��Top=�6e   $	��242��6}    6�   �� $ txtInterestRate��$ OneWay=��� 5   
   -   5        $ txtYears��5      $
��Left=�6$   $��37��6?   $��389,157,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��289��6�   �� 5   
   $��_Number of years:��6   $
��Left=�6,   $��37��6G   $��125,157,0,0q�6S   $	��Top=�6h   $	��242��6�    6�   �� $ txtYears��$ OneWay=��� 5   
   $��Future value:��6   $
��Left=�6(   $��37��6C   $��125,217,0,0q�6O   $	��Top=�6d   $	��242��6|   �� 5   
   -   5         ��Name$ lblFutureValue��5      $�� ��6(   $
��Left=�63   $��37��6N   $��389,217,0,0q�6Z   $	��Top=�6o   $	��289��6�   
���   �$��1,1,1,1q�6�   $��Center=�6�   �� 5   
   -   5         ��Name$ btnCalculate��5      $��
_Calculate��6'   $
��Left=�6<   $��53��6W   $��189,317,0,0q�6c   $	��Top=�6x   $	��157��6�   6�   �� 5   
   -   5        $ btnExit��5      $��E_xit��6"   $
��Left=�62   $��53��6M   $��437,312,0,0q�6Y   $	��Top=�6n   $	��157��6�   6�   5      5      