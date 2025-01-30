Module Globals
    Public User As Integer  ' User ID
    Public Login As Boolean = False ' User Logged In
    Public Admin As Boolean = False ' Admin User
    Public HelpMessages As Boolean = False ' Show Help Messages
    Public WOProperty As Integer ' Work Order Property ID
    Public WOID As Integer ' Work Order ID
    Public VendorID As Integer ' Vendor ID
    Public ByVendor As Boolean = False ' Work Order By Vendor Search Flag
    Public PropertyID As Integer ' Property ID
    Public PaymentID As Integer ' Payment ID
    Public TenantID As Integer ' Tenant ID
    Public TenantName As String ' Tenant Name
    Public TenantTotalPaid As Decimal ' Total Paid Per Tenant
    Public TotalPropertyPaid As Decimal ' Total Paid Per Property
    Public Rent As String
    Public DueDate As String
    Public CompanyID As Integer = 1
    Public ChargeID As Integer
    Public CompanyDetails As String
    Public ChargeDetails As String
    Public WOtotalcharge As Decimal
    Public connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\db\Property_Manager.accdb"
    Public UsersTableAdapter As New Property_ManagerDataSetTableAdapters.UsersTableAdapter()
    Public PropertiesTableAdapter As New Property_ManagerDataSetTableAdapters.PropertiesTableAdapter()
    Public TenantsTableAdapter As New Property_ManagerDataSetTableAdapters.TenantsTableAdapter()
    Public PaymentsTableAdapter As New Property_ManagerDataSetTableAdapters.PaymentsTableAdapter()
    Public PaymentTypesTableAdapter As New Property_ManagerDataSetTableAdapters.PaymentTypesTableAdapter()
    Public VendorsTableAdapter As New Property_ManagerDataSetTableAdapters.VendorsTableAdapter()
    Public WorkOrdersTableAdapter As New Property_ManagerDataSetTableAdapters.WorkOrdersTableAdapter()
    Public EmployeesTableAdapter As New Property_ManagerDataSetTableAdapters.EmployeesTableAdapter()
    Public ChargesTableAdapter As New Property_ManagerDataSetTableAdapters.ChargesTableAdapter()
    Public Sub GetCompanyDetails()
        ' Get the company details from the database and put them in the CompanyDetails variable
        Dim conn As New OleDb.OleDbConnection(connectionString)
        Dim cmd As New OleDb.OleDbCommand
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            cmd.Connection = conn
            cmd.CommandText = "SELECT Company, Address, Address2, City, State, Zip, Phone, Fax FROM Company"
            Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                CompanyDetails = reader("Company") & vbCrLf & reader("Address") & " " & reader("Address2") & vbCrLf & reader("City") & ", " & reader("State") & " " & reader("Zip") & vbCrLf & "Phone: " & reader("Phone") & vbCrLf & "Fax: " & reader("Fax")
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

        End Try
    End Sub
    ' Routine to verify the user wants to exit the application
    ' Need to pass the button that was clicked
    Public Sub VerifyExit(sender As Object, e As EventArgs, exitButton As Button)
        ' Remove any existing handlers to avoid multiple additions
        RemoveHandler exitButton.Click, AddressOf VerifyExitHandler
        ' Add the handler
        AddHandler exitButton.Click, AddressOf VerifyExitHandler
    End Sub

    Private Sub VerifyExitHandler(sender As Object, e As EventArgs)
        Dim response As MsgBoxResult
        response = MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Exit")
        If response = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Module
