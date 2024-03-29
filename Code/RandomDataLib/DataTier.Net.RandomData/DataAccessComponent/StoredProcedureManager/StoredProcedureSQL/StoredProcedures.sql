Use [RandomData]

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Address_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Insert a new Address
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Address_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Address_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Address_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Address_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Address_Insert >>>'

    End

GO

Create PROCEDURE Address_Insert

    -- Add the parameters for the stored procedure here
    @City nvarchar(50),
    @MemberId int,
    @StateId int,
    @StreetAddress nvarchar(255),
    @Unit nvarchar(10),
    @ZipCode nvarchar(10)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [Address]
    ([City],[MemberId],[StateId],[StreetAddress],[Unit],[ZipCode])

    -- Begin Values List
    Values(@City, @MemberId, @StateId, @StreetAddress, @Unit, @ZipCode)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Address_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Update an existing Address
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Address_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Address_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Address_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Address_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Address_Update >>>'

    End

GO

Create PROCEDURE Address_Update

    -- Add the parameters for the stored procedure here
    @City nvarchar(50),
    @Id int,
    @MemberId int,
    @StateId int,
    @StreetAddress nvarchar(255),
    @Unit nvarchar(10),
    @ZipCode nvarchar(10)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [Address]

    -- Update Each field
    Set [City] = @City,
    [MemberId] = @MemberId,
    [StateId] = @StateId,
    [StreetAddress] = @StreetAddress,
    [Unit] = @Unit,
    [ZipCode] = @ZipCode

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Address_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Find an existing Address
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Address_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Address_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Address_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Address_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Address_Find >>>'

    End

GO

Create PROCEDURE Address_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [City],[Id],[MemberId],[StateId],[StreetAddress],[Unit],[ZipCode]

    -- From tableName
    From [Address]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Address_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Delete an existing Address
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Address_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Address_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Address_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Address_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Address_Delete >>>'

    End

GO

Create PROCEDURE Address_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [Address]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Address_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Returns all Address objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Address_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Address_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Address_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Address_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Address_FetchAll >>>'

    End

GO

Create PROCEDURE Address_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [City],[Id],[MemberId],[StateId],[StreetAddress],[Unit],[ZipCode]

    -- From tableName
    From [Address]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: FirstName_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Insert a new FirstName
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('FirstName_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure FirstName_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.FirstName_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure FirstName_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure FirstName_Insert >>>'

    End

GO

Create PROCEDURE FirstName_Insert

    -- Add the parameters for the stored procedure here
    @Name nvarchar(25)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [FirstName]
    ([Name])

    -- Begin Values List
    Values(@Name)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: FirstName_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Update an existing FirstName
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('FirstName_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure FirstName_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.FirstName_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure FirstName_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure FirstName_Update >>>'

    End

GO

Create PROCEDURE FirstName_Update

    -- Add the parameters for the stored procedure here
    @Id int,
    @Name nvarchar(25)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [FirstName]

    -- Update Each field
    Set [Name] = @Name

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: FirstName_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Find an existing FirstName
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('FirstName_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure FirstName_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.FirstName_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure FirstName_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure FirstName_Find >>>'

    End

GO

Create PROCEDURE FirstName_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Name]

    -- From tableName
    From [FirstName]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: FirstName_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Delete an existing FirstName
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('FirstName_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure FirstName_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.FirstName_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure FirstName_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure FirstName_Delete >>>'

    End

GO

Create PROCEDURE FirstName_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [FirstName]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: FirstName_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Returns all FirstName objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('FirstName_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure FirstName_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.FirstName_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure FirstName_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure FirstName_FetchAll >>>'

    End

GO

Create PROCEDURE FirstName_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Name]

    -- From tableName
    From [FirstName]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: LastName_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Insert a new LastName
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('LastName_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure LastName_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.LastName_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure LastName_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure LastName_Insert >>>'

    End

GO

Create PROCEDURE LastName_Insert

    -- Add the parameters for the stored procedure here
    @Name nvarchar(25)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [LastName]
    ([Name])

    -- Begin Values List
    Values(@Name)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: LastName_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Update an existing LastName
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('LastName_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure LastName_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.LastName_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure LastName_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure LastName_Update >>>'

    End

GO

Create PROCEDURE LastName_Update

    -- Add the parameters for the stored procedure here
    @Id int,
    @Name nvarchar(25)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [LastName]

    -- Update Each field
    Set [Name] = @Name

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: LastName_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Find an existing LastName
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('LastName_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure LastName_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.LastName_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure LastName_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure LastName_Find >>>'

    End

GO

Create PROCEDURE LastName_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Name]

    -- From tableName
    From [LastName]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: LastName_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Delete an existing LastName
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('LastName_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure LastName_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.LastName_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure LastName_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure LastName_Delete >>>'

    End

GO

Create PROCEDURE LastName_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [LastName]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: LastName_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Returns all LastName objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('LastName_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure LastName_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.LastName_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure LastName_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure LastName_FetchAll >>>'

    End

GO

Create PROCEDURE LastName_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Name]

    -- From tableName
    From [LastName]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Member_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Insert a new Member
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Member_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Member_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Member_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Member_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Member_Insert >>>'

    End

GO

Create PROCEDURE Member_Insert

    -- Add the parameters for the stored procedure here
    @Active bit,
    @FirstName nvarchar(25),
    @LastName nvarchar(25)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [Member]
    ([Active],[FirstName],[LastName])

    -- Begin Values List
    Values(@Active, @FirstName, @LastName)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Member_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Update an existing Member
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Member_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Member_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Member_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Member_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Member_Update >>>'

    End

GO

Create PROCEDURE Member_Update

    -- Add the parameters for the stored procedure here
    @Active bit,
    @FirstName nvarchar(25),
    @Id int,
    @LastName nvarchar(25)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [Member]

    -- Update Each field
    Set [Active] = @Active,
    [FirstName] = @FirstName,
    [LastName] = @LastName

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Member_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Find an existing Member
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Member_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Member_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Member_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Member_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Member_Find >>>'

    End

GO

Create PROCEDURE Member_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Active],[FirstName],[Id],[LastName]

    -- From tableName
    From [Member]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Member_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Delete an existing Member
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Member_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Member_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Member_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Member_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Member_Delete >>>'

    End

GO

Create PROCEDURE Member_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [Member]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Member_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Returns all Member objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Member_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Member_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Member_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Member_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Member_FetchAll >>>'

    End

GO

Create PROCEDURE Member_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Active],[FirstName],[Id],[LastName]

    -- From tableName
    From [Member]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: MemberAddressView_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Returns all MemberAddressView objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('MemberAddressView_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure MemberAddressView_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.MemberAddressView_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure MemberAddressView_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure MemberAddressView_FetchAll >>>'

    End

GO

Create PROCEDURE MemberAddressView_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [AddressId],[City],[FirstName],[LastName],[MemberId],[StateCode],[StateId],[StateName],[StreetAddress],[Unit],[ZipCode]

    -- From tableName
    From [MemberAddressView]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: State_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Insert a new State
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('State_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure State_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.State_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure State_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure State_Insert >>>'

    End

GO

Create PROCEDURE State_Insert

    -- Add the parameters for the stored procedure here
    @Code nvarchar(10),
    @Name nvarchar(50)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [State]
    ([Code],[Name])

    -- Begin Values List
    Values(@Code, @Name)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: State_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Update an existing State
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('State_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure State_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.State_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure State_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure State_Update >>>'

    End

GO

Create PROCEDURE State_Update

    -- Add the parameters for the stored procedure here
    @Code nvarchar(10),
    @Id int,
    @Name nvarchar(50)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [State]

    -- Update Each field
    Set [Code] = @Code,
    [Name] = @Name

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: State_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Find an existing State
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('State_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure State_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.State_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure State_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure State_Find >>>'

    End

GO

Create PROCEDURE State_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Code],[Id],[Name]

    -- From tableName
    From [State]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: State_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Delete an existing State
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('State_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure State_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.State_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure State_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure State_Delete >>>'

    End

GO

Create PROCEDURE State_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [State]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: State_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Returns all State objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('State_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure State_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.State_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure State_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure State_FetchAll >>>'

    End

GO

Create PROCEDURE State_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Code],[Id],[Name]

    -- From tableName
    From [State]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: StreetName_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Insert a new StreetName
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('StreetName_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure StreetName_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.StreetName_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure StreetName_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure StreetName_Insert >>>'

    End

GO

Create PROCEDURE StreetName_Insert

    -- Add the parameters for the stored procedure here
    @Name nvarchar(255)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [StreetName]
    ([Name])

    -- Begin Values List
    Values(@Name)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: StreetName_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Update an existing StreetName
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('StreetName_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure StreetName_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.StreetName_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure StreetName_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure StreetName_Update >>>'

    End

GO

Create PROCEDURE StreetName_Update

    -- Add the parameters for the stored procedure here
    @Id int,
    @Name nvarchar(255)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [StreetName]

    -- Update Each field
    Set [Name] = @Name

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: StreetName_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Find an existing StreetName
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('StreetName_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure StreetName_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.StreetName_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure StreetName_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure StreetName_Find >>>'

    End

GO

Create PROCEDURE StreetName_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Name]

    -- From tableName
    From [StreetName]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: StreetName_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Delete an existing StreetName
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('StreetName_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure StreetName_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.StreetName_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure StreetName_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure StreetName_Delete >>>'

    End

GO

Create PROCEDURE StreetName_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [StreetName]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: StreetName_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Returns all StreetName objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('StreetName_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure StreetName_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.StreetName_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure StreetName_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure StreetName_FetchAll >>>'

    End

GO

Create PROCEDURE StreetName_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Name]

    -- From tableName
    From [StreetName]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ZipCode_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Insert a new ZipCode
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ZipCode_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ZipCode_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ZipCode_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ZipCode_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ZipCode_Insert >>>'

    End

GO

Create PROCEDURE ZipCode_Insert

    -- Add the parameters for the stored procedure here
    @CityName nvarchar(50),
    @Name nvarchar(10),
    @StateId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [ZipCode]
    ([CityName],[Name],[StateId])

    -- Begin Values List
    Values(@CityName, @Name, @StateId)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ZipCode_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Update an existing ZipCode
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ZipCode_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ZipCode_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ZipCode_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ZipCode_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ZipCode_Update >>>'

    End

GO

Create PROCEDURE ZipCode_Update

    -- Add the parameters for the stored procedure here
    @CityName nvarchar(50),
    @Id int,
    @Name nvarchar(10),
    @StateId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [ZipCode]

    -- Update Each field
    Set [CityName] = @CityName,
    [Name] = @Name,
    [StateId] = @StateId

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ZipCode_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Find an existing ZipCode
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ZipCode_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ZipCode_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ZipCode_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ZipCode_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ZipCode_Find >>>'

    End

GO

Create PROCEDURE ZipCode_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CityName],[Id],[Name],[StateId]

    -- From tableName
    From [ZipCode]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ZipCode_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Delete an existing ZipCode
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ZipCode_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ZipCode_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ZipCode_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ZipCode_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ZipCode_Delete >>>'

    End

GO

Create PROCEDURE ZipCode_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [ZipCode]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ZipCode_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Returns all ZipCode objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ZipCode_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ZipCode_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ZipCode_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ZipCode_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ZipCode_FetchAll >>>'

    End

GO

Create PROCEDURE ZipCode_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CityName],[Id],[Name],[StateId]

    -- From tableName
    From [ZipCode]

END

-- Begin Custom Methods


set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: State_FindByName
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   8/16/2019
-- Description:    Find an existing State for the Name given.
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('State_FindByName'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure State_FindByName

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.State_FindByName') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure State_FindByName >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure State_FindByName >>>'

    End

GO

Create PROCEDURE State_FindByName

    -- Create @Name Paramater
    @Name nvarchar(50)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Code],[Id],[Name]

    -- From tableName
    From [State]

    -- Find Matching Record
    Where [Name] = @Name

END


-- End Custom Methods

-- Thank you for using DataTier.Net.

