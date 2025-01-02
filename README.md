# Ejemplo de Bases de Datos

# Descripcion

 Este proyecto consiste en el desarrollo de una aplicacion que emplea
 el CRUD en una base de datos ACCESS 2016 para la manipulacion de los
 registros: Inserta, Consulta, Actualiza y Elimina registros de la 
 base de datos de manera muy sencilla. se basa en el uso de objetos 
 DataReader, DataSet, DataTable para generar una copia en memoria de 
 la base de datos y esa copia va a ser rellenada con la informacion
 de las filas y las columnas de la base de datos empleando un objeto 
 DataRow, es necesario emplear un espacio de nombres que permita 
 ejecutar sentencias SQL que contendran la cadena de conexion e 
 instrucciones que permitiran la manipulacion de los registros de la 
 base de datos. 
 
 # Actualizacion: 02/01/2025
 # Hora: 15:31

# Database Example

# Description

This project consists of the development of an application that uses
CRUD in an ACCESS 2016 database for the manipulation of records: 
Insert, Query, Update and Delete records from the database in a very 
simple way. It is based on the use of DataReader, DataSet, 
DataTable objects to generate a copy in memory of the database and 
that copy will be filled with the information of the rows and columns 
of the database using a DataRow object. It is necessary to use a 
namespace that allows the execution of SQL statements that will 
contain the connection string and instructions that will allow 
the manipulation of the records in the database.

# Update: 02/01/2025
# Time: 15:31

Technical Details of the Project:
Language: Visual Basic.NET
Framework Version: 4.7.2

![imagen](https://github.com/user-attachments/assets/cdcfc92e-cfd9-4dd1-b516-76cb5960c834)

Code of the Project:

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
