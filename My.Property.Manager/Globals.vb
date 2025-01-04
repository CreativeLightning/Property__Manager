Module Globals
    Public User As Integer  ' User ID
    Public Login As Boolean = False ' User Logged In
    Public Admin As Boolean = False ' Admin User
    Public HelpMessages As Boolean = True ' Show Help Messages
    Public WOProperty As Integer ' Work Order Property ID
    Public WOID As Integer ' Work Order ID
    Public VendorID As Integer ' Vendor ID
    Public ByVendor As Boolean = False ' Work Order By Vendor Search Flag
    Public PropertyID As Integer ' Property ID
    Public PaymentID As Integer ' Payment ID
    Public TenantID As Integer ' Tenant ID
    Public TenantName As String ' Tenant Name
    Public TenantTotalPaid As Decimal ' Tenant Total Paid
    Public Rent As String
    Public DueDate As String
    Public CompanyID As Integer = 1
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

End Module
