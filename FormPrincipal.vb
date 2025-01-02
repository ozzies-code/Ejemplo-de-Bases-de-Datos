Public Class FormPrincipal

    Private m_cn As New OleDbConnection()
    Private m_DA As OleDbDataAdapter
    Private m_CB As OleDbCommandBuilder
    Private m_DataTable As New DataTable
    Private m_posFila As Integer = 0
    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        m_cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\oswal\Documents\prueba.accdb"

        m_cn.Open()

        m_DA = New OleDbDataAdapter("SELECT * FROM CLIENTES", m_cn)

        m_CB = New OleDbCommandBuilder(m_DA)

        m_DA.Fill(m_DataTable)

        Me.MostrarRegistroActual()

    End Sub

    Private Sub FormPrincipal_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        m_cn.Close()
        m_cn.Dispose()
    End Sub

    Private Sub MostrarRegistroActual()

        If m_DataTable.Rows.Count = 0 Then

            txtNombres.Text = ""
            txtNumId.Text = ""
            txtIdCliente.Text = ""
            txtTelefono.Text = ""
            Exit Sub
        End If

        txtNombres.Text = m_DataTable.Rows(m_posFila)("NOMBRES").ToString()
        txtNumId.Text = m_DataTable.Rows(m_posFila)("NOIDENTIFICACION").ToString()
        txtIdCliente.Text = m_DataTable.Rows(m_posFila)("IDCLIENTE").ToString()
        txtTelefono.Text = m_DataTable.Rows(m_posFila)("TELEFONO").ToString()

    End Sub

    Private Sub btnIrAPrimero_Click(sender As Object, e As EventArgs) Handles btnIrAPrimero.Click

        'Ir al primer registro y mostrar los datos.
        m_posFila = 0
        Me.MostrarRegistroActual()
    End Sub

    Private Sub btnIrAAnterior_Click(sender As Object, e As EventArgs) Handles btnIrAAnterior.Click

        'Si no estamos en el primer registro, ir al registro anterior.

        If m_posFila > 0 Then
            m_posFila = m_posFila - 1
            Me.MostrarRegistroActual()
        End If
    End Sub

    Private Sub btnIrASiguiente_Click(sender As Object, e As EventArgs) Handles btnIrASiguiente.Click

        'Si no estamos en el ultimo registro, ir al registro siguiente.

        If m_posFila < (m_DataTable.Rows.Count - 1) Then
            m_posFila = m_posFila + 1
            Me.MostrarRegistroActual()
        End If

    End Sub

    Private Sub btnIrAUltimo_Click(sender As Object, e As EventArgs) Handles btnIrAUltimo.Click

        'Si hay algun registro en la tabla,
        'ir al ultimo registro y mostrarlo.

        If m_DataTable.Rows.Count > 0 Then

            m_posFila = m_DataTable.Rows.Count - 1
            Me.MostrarRegistroActual()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        'Si hay datos, actualizarlos.
        If m_DataTable.Rows.Count <> 0 Then

            m_DataTable.Rows(m_posFila)("NOMBRES") = txtNombres.Text
            m_DataTable.Rows(m_posFila)("NOIDENTIFICACION") = txtNumId.Text
            m_DataTable.Rows(m_posFila)("IDCLIENTE") = txtIdCliente.Text
            m_DataTable.Rows(m_posFila)("TELEFONO") = txtTelefono.Text
            m_DA.Update(m_DataTable)

            MsgBox("Registro Guardado")
        End If
    End Sub

    Private Sub btnNuevoRegistro_Click(sender As Object, e As EventArgs) Handles btnNuevoRegistro.Click


        Dim drNuevaFila As DataRow = m_DataTable.NewRow

        drNuevaFila("NOMBRES") = txtNombreNuevoContacto.Text
        drNuevaFila("NOIDENTIFICACION") = txtNumIdNuevo.Text
        drNuevaFila("IDCLIENTE") = txtIdClienteNuevo.Text
        drNuevaFila("TELEFONO") = txtTelefonoNuevo.Text

        m_DataTable.Rows.Add(drNuevaFila)
        m_DA.Update(m_DataTable)
        m_posFila = m_DataTable.Rows.Count - 1
        Me.MostrarRegistroActual()


    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        'Si hay datos, borrar el registro actual.

        If m_DataTable.Rows.Count <> 0 Then
            m_DataTable.Rows(m_posFila).Delete()
            m_DA.Update(m_DataTable)
            m_posFila = 0
            Me.MostrarRegistroActual()

            MsgBox("Registro Eliminado")
        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtNombreNuevoContacto.Clear()
        txtIdClienteNuevo.Clear()
        txtNumIdNuevo.Clear()
        txtTelefonoNuevo.Clear()
    End Sub
End Class
