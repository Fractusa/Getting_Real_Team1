   M S B A M L   `   `   `  ����G  CGetting_Real, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Getting_RealGetting_Real  5   	       Getting_Real.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Getting_Real     5   	   -   5          � Title$  Ritz - Parkeringssystem��5   	   $	��450��6)   $	��800��66    � 
ResizeMode$ CanMinimize=�5
   	   .��5      � $��	0,0,84,-6q�6   .+�5   
   �� -   5         ��Name$ lblParkings��5      $a��[Parkeringspladser format:
 Navn, Bookingnr., Nummerplade, Ankomst, Afrejse, Parkeringsplads��6%   $
��Left=�6�   $��	38,24,0,0q�6�   $	��Top=�6�   �� 5   
   -   5         ��Name$ btnAddParking��5      $��Tilføj Parkering��6(   $
��Left=�6C   $��617,373,0,0q�6^   $	��Top=�6s   6�   �� 5   
   -   5        $ btnDeleteParking��5      $��Slet Parkering��6+   $
��Left=�6D   $��524,373,0,0q�6_   $	��Top=�6t    J� RenderTransformOrigin$ -2.869,1.856&�6�   6�   �� 5   
   -   5        $ lblOwner��5      $��Fulde navn:��6"   $
��Left=�68   $��
434,47,0,0q�6S   $	��Top=�6g   $��32��6   $��81��6�   �� 5   
   -   5        $ 
lblBooking��5      $��
Bookingnr:��6$   $
��Left=�69   $��434,103,0,0q�6T   $	��Top=�6i   $��33��6�   $��77��6�   �� 5   
   -   5        $ lblDeparture��5      $��Afrejse:��6&   $
��Left=�69   $��436,272,0,0q�6T   $	��Top=�6i   $��32��6�   $��56��6�   �� 5   
   -   5        $ lblNumberPlate��5      $��Nummerplade:��6(   $
��Left=�6?   $��434,159,0,0q�6Z   $	��Top=�6o   $��33��6�   $	��102��6�   �� 5   
   -	   5        $ 
lblArrival��5      $��Ankomst:��6$   $
��Left=�67   $��436,216,0,0q�6R   $	��Top=�6g   $��32��6   $��68��6�   �� 5   
   -
   5        $ lblParkingSpot��5      $��Parkeringsplads:��6(   $
��Left=�6C   $��436,328,0,0q�6^   $	��Top=�6s   $��33��6�   $	��110��6�   �� 5   
   -   5         ��Name$ txtName��5      $
��Left=�6#   $��
562,52,0,0q�6>    �� TextWrapping$
 Wrap=�6R   $	��Top=�6�   $	��138��6�   $��22��6�   ��6f   �� *SelectedVehicle.OwnerName+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   -   5        $ 
txtBooking��5      $
��Left=�6&   $��562,108,0,0q�6A   $
 Wrap=�6V   $	��Top=�6�   $	��138��6�   $��23��6�   ��6j   �� *$"SelectedVehicle.OwnerBookingNumber+$ PropertyChanged=�6�   �� 5   
   -   5        $ txtNumberPlate��5      $
��Left=�6*   $��562,164,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6�   $	��138��6�   $��23��6�   ��6n   �� *SelectedVehicle.NumberPlate+$ PropertyChanged=�6�   �� 5   
   -   5        $ 
txtArrival��5      $
��Left=�6&   $��562,221,0,0q�6A   $
 Wrap=�6V   $	��Top=�6�   $	��138��6�   $��22��6�   ��6j   �� *SelectedVehicle.ArrivalDate+$ PropertyChanged=�6�   �� 5   
   -   5        $ txtDeparture��5      $
��Left=�6(   $��562,277,0,0q�6C   $
 Wrap=�6X   $	��Top=�6�   $	��138��6�   $��22��6�   ��6l   �� *SelectedVehicle.DepartureDate+$ PropertyChanged=�6�   �� 5   
   -   5        $ txtParkingSpot��5      $
��Left=�6*   $��562,333,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6�   $	��138��6�   $��23��6�   $ 0.49,-0.132&�6�   ��6n   �� *SelectedVehicle.ParkingSpotId+$ PropertyChanged=�6�   �� 5   
   -   5        $ btnUpdateList��5      $��Opdater Liste��6(   $
��Left=�6@   $��434,373,0,0q�6[   $	��Top=�6p   6�   �� 5   
   -   5         ��Name$ listBox��5      $��31,66,301,34q�6|   ��6#   �� *
VehiclesVM+	 �� SelectedItem	 6F   �� *SelectedVehicle+
 �� Mode$
 TwoWay=���5      �� 5       .R�5!      ��  �� Orientation$ 
Horizontal=�6!   .+�5"      �� ��6    �� *	OwnerName+�� 5#      ��6    �� *OwnerBookingNumber+�� 5$      ��6    �� *NumberPlate+�� 5%      ��6    �� *ArrivalDate+�� 5&      ��6    �� *DepartureDate+�� 5'      ��6    �� *ParkingSpotId+5(      5)      5+      �� 5,   
   $ 
Horizontal=�6   $��
0,0,614,21q�6.   �� 5-   
   -   5        $ lblArrivalFormat��5-      $��Format: ��6*   $
��Left=�6=   $��562,200,0,0q�6X   $	��Top=�6m   $��21��6�   $	��105��6�   $��10(�6�   �� 5.   
   -   5        $ lblDepartureFormat��5.      $��Format: ��6,   $
��Left=�6?   $��562,256,0,0q�6Z   $	��Top=�6o   $��21��6�   $	��105��6�   $��10(�6�   5/      51      