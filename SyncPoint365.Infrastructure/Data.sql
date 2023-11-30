INSERT INTO [dbo].[Countries] ([Name])
VALUES ('United States');

INSERT INTO [dbo].[Countries] ([Name])
VALUES ('Canada');

INSERT INTO [dbo].[Countries] ([Name])
VALUES ('United Kingdom');

INSERT INTO [dbo].[Countries] ([Name])
VALUES ('Australia');

INSERT INTO [dbo].[Countries] ([Name])
VALUES ('Germany');

-- Inserting Countries
INSERT INTO [dbo].[Countries] ([Name])
VALUES ('United States');

INSERT INTO [dbo].[Countries] ([Name])
VALUES ('Canada');

INSERT INTO [dbo].[Countries] ([Name])
VALUES ('United Kingdom');

INSERT INTO [dbo].[Countries] ([Name])
VALUES ('Australia');

INSERT INTO [dbo].[Countries] ([Name])
VALUES ('Germany');

-- Inserting Cities for United States
INSERT INTO [dbo].[Cities] ([Name], [CountryId])
VALUES ('New York', 1);

INSERT INTO [dbo].[Cities] ([Name], [CountryId])
VALUES ('Los Angeles', 1);

INSERT INTO [dbo].[Cities] ([Name], [CountryId])
VALUES ('Chicago', 1);

INSERT INTO [dbo].[Cities] ([Name], [CountryId])
VALUES ('Houston', 1);

INSERT INTO [dbo].[Cities] ([Name], [CountryId])
VALUES ('Phoenix', 1);

-- Inserting Cities for Canada
INSERT INTO [dbo].[Cities] ([Name], [CountryId])
VALUES ('Toronto', 2);

INSERT INTO [dbo].[Cities] ([Name], [CountryId])
VALUES ('Vancouver', 2);

INSERT INTO [dbo].[Cities] ([Name], [CountryId])
VALUES ('Montreal', 2);

INSERT INTO [dbo].[Cities] ([Name], [CountryId])
VALUES ('Calgary', 2);

INSERT INTO [dbo].[Cities] ([Name], [CountryId])
VALUES ('Ottawa', 2);

-- Inserting Cities for United Kingdom
INSERT INTO [dbo].[Cities] ([Name], [CountryId])
VALUES ('London', 3);

INSERT INTO [dbo].[Cities] ([Name], [CountryId])
VALUES ('Manchester', 3);

INSERT INTO [dbo].[Cities] ([Name], [CountryId])
VALUES ('Birmingham', 3);

INSERT INTO [dbo].[Cities] ([Name], [CountryId])
VALUES ('Glasgow', 3);

INSERT INTO [dbo].[Cities] ([Name], [CountryId])
VALUES ('Liverpool', 3);

-- Inserting Cities for Australia
INSERT INTO [dbo].[Cities] ([Name], [CountryId])
VALUES ('Sydney', 4);

INSERT INTO [dbo].[Cities] ([Name], [CountryId])
VALUES ('Melbourne', 4);

INSERT INTO [dbo].[Cities] ([Name], [CountryId])
VALUES ('Brisbane', 4);

INSERT INTO [dbo].[Cities] ([Name], [CountryId])
VALUES ('Perth', 4);

INSERT INTO [dbo].[Cities] ([Name], [CountryId])
VALUES ('Adelaide', 4);

-- Inserting Cities for Germany
INSERT INTO [dbo].[Cities] ([Name], [CountryId])
VALUES ('Berlin', 5);

INSERT INTO [dbo].[Cities] ([Name], [CountryId])
VALUES ('Hamburg', 5);

INSERT INTO [dbo].[Cities] ([Name], [CountryId])
VALUES ('Munich', 5);

INSERT INTO [dbo].[Cities] ([Name], [CountryId])
VALUES ('Cologne', 5);

INSERT INTO [dbo].[Cities] ([Name], [CountryId])
VALUES ('Frankfurt', 5);

INSERT INTO [dbo].[Companies] ([Email], [IdNumber],[Name],[PhoneNumber],[VacationDays],[VatNumber],[ZipCode],[CityId],[County],[State])
VALUES
('office@breakpoint.software', '00000', 'BreakPoint', '061-842-239',20,'00000', '88000', 1, NULL, NULL);

INSERT INTO [dbo].[Users] ([Address], [BirthDate], [BirthPlace], [BusinessEmail], [BusinessUnit], [ContractNumber], [County], [Department], [FirstName], [Gender], [LastName], [Municipality], [Nationality], [PasswordHash], [PasswordSalt], [PhoneNumber], [Position], [PrivateEmail], [SocialSecurityNumber], [State], [VacationDays], [ZipCode], [CityId], [Role], [CompanyId])
VALUES
('123 Main St', '1990-01-01T00:00:00.0000000', 'New York', 'john.doe@company.com', 'IT Department', '12345', 'New York County', 'IT', 'John', 1, 'Doe', 'New York', 'US', '63FC1D48254C38E50EEBA7EAF6203D91BB78413E75BE66D343FC9BEEC64D8495D533E63E05FCBE6072441E796F4AF2FF51A8CE69AFDC2AA6AF2330C4E310279F', 'Doj+wyvOccMksCKMlKDg1IQO4PnUu35OO6Yido++7z6wtoys6PerehiT2ecw4zboyzfPFYygi+vzRKoiLBomLw==', '555-123-4567', 'Software Engineer', 'john@gmail.com', '123-45-6789', 'NY', 20, '12345', 1, 0, NULL);

INSERT INTO [dbo].[Users] ([Address], [BirthDate], [BirthPlace], [BusinessEmail], [BusinessUnit], [ContractNumber], [County], [Department], [FirstName], [Gender], [LastName], [Municipality], [Nationality], [PasswordHash], [PasswordSalt], [PhoneNumber], [Position], [PrivateEmail], [SocialSecurityNumber], [State], [VacationDays], [ZipCode], [CityId], [Role], [CompanyId])
VALUES
('456 Elm St', '1985-05-15T00:00:00.0000000', 'Los Angeles', 'jane.smith@company.com', 'HR Department', '67890', 'Los Angeles County', 'HR', 'Jane', 2, 'Smith', 'Los Angeles', 'US', '63FC1D48254C38E50EEBA7EAF6203D91BB78413E75BE66D343FC9BEEC64D8495D533E63E05FCBE6072441E796F4AF2FF51A8CE69AFDC2AA6AF2330C4E310279F', 'Doj+wyvOccMksCKMlKDg1IQO4PnUu35OO6Yido++7z6wtoys6PerehiT2ecw4zboyzfPFYygi+vzRKoiLBomLw==', '555-987-6543', 'HR Manager', 'jane@gmail.com', '987-65-4321', 'CA', 25, '67890', 2, 1, 1);

INSERT INTO [dbo].[Users] ([Address], [BirthDate], [BirthPlace], [BusinessEmail], [BusinessUnit], [ContractNumber], [County], [Department], [FirstName], [Gender], [LastName], [Municipality], [Nationality], [PasswordHash], [PasswordSalt], [PhoneNumber], [Position], [PrivateEmail], [SocialSecurityNumber], [State], [VacationDays], [ZipCode], [CityId], [Role], [CompanyId])
VALUES
('789 Oak St', '1988-10-20T00:00:00.0000000', 'Chicago', 'mary.jones@company.com', 'Finance Department', '54321', 'Cook County', 'Finance', 'Mary', 2, 'Jones', 'Chicago', 'US', '63FC1D48254C38E50EEBA7EAF6203D91BB78413E75BE66D343FC9BEEC64D8495D533E63E05FCBE6072441E796F4AF2FF51A8CE69AFDC2AA6AF2330C4E310279F', 'Doj+wyvOccMksCKMlKDg1IQO4PnUu35OO6Yido++7z6wtoys6PerehiT2ecw4zboyzfPFYygi+vzRKoiLBomLw==', '555-234-5678', 'Financial Analyst', 'mary@yahoo.com', '876-54-3210', 'IL', 18, '54321', 3, 2, 1);

INSERT INTO [dbo].[Users] ([Address], [BirthDate], [BirthPlace], [BusinessEmail], [BusinessUnit], [ContractNumber], [County], [Department], [FirstName], [Gender], [LastName], [Municipality], [Nationality], [PasswordHash], [PasswordSalt], [PhoneNumber], [Position], [PrivateEmail], [SocialSecurityNumber], [State], [VacationDays], [ZipCode], [CityId], [Role], [CompanyId])
VALUES
('321 Pine St', '1993-03-08T00:00:00.0000000', 'Houston', 'mark.wilson@company.com', 'Marketing Department', '43210', 'Harris County', 'Marketing', 'Mark', 1, 'Wilson', 'Houston', 'US', '63FC1D48254C38E50EEBA7EAF6203D91BB78413E75BE66D343FC9BEEC64D8495D533E63E05FCBE6072441E796F4AF2FF51A8CE69AFDC2AA6AF2330C4E310279F', 'Doj+wyvOccMksCKMlKDg1IQO4PnUu35OO6Yido++7z6wtoys6PerehiT2ecw4zboyzfPFYygi+vzRKoiLBomLw==', '555-876-5432', 'Marketing Manager', 'mark@hotmail.com', '765-43-2109', 'TX', 15, '43210', 4, 2, 1);

INSERT INTO [dbo].[Users] ([Address], [BirthDate], [BirthPlace], [BusinessEmail], [BusinessUnit], [ContractNumber], [County], [Department], [FirstName], [Gender], [LastName], [Municipality], [Nationality], [PasswordHash], [PasswordSalt], [PhoneNumber], [Position], [PrivateEmail], [SocialSecurityNumber], [State], [VacationDays], [ZipCode], [CityId], [Role], [CompanyId])
VALUES
('567 Maple St', '1995-12-03T00:00:00.0000000', 'Phoenix', 'susan.johnson@company.com', 'Sales Department', '98765', 'Maricopa County', 'Sales', 'Susan', 2, 'Johnson', 'Phoenix', 'US', '63FC1D48254C38E50EEBA7EAF6203D91BB78413E75BE66D343FC9BEEC64D8495D533E63E05FCBE6072441E796F4AF2FF51A8CE69AFDC2AA6AF2330C4E310279F', 'Doj+wyvOccMksCKMlKDg1IQO4PnUu35OO6Yido++7z6wtoys6PerehiT2ecw4zboyzfPFYygi+vzRKoiLBomLw==', '555-765-4321', 'Sales Representative', 'susan@gmail.com', '654-32-1098', 'AZ', 22, '98765', 5, 2, 1);