Imports MySql.Data.MySqlClient
Module ModFunction
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public data As New DataSet
    Public table As New DataTable

    Public mylogin As New Login
    Sub openCon()
        con.ConnectionString = "server=localhost;username=root;password=;database=wt_db"
        con.Open()
    End Sub
End Module
