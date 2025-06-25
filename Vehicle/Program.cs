// See https://aka.ms/new-console-template for more information

using WithStrategy;

Vehicle sportsVehicle = new OffRoadVehicle();
sportsVehicle.Drive();

Vehicle passengerVehicle = new PassengerVehicle();
passengerVehicle.Drive();