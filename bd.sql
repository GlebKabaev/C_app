create table Futurainfo(
	ID serial Primary Key,
	IDfutura Int,
	Foreign key(IDfutura) REFERENCES Futura(Id),
	Quantity Double precision,
	Price Double precision
)