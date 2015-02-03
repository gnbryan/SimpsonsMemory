Public Class frm_memory
    Public Enum Figuras
        abe
        bart
        homer
        lisa
        maggie
        marge
    End Enum
    ''' <summary>
    ''' Variable mostrada.
    ''' </summary>
    ''' <remarks>Variable booleana que nos va a indicar si a la hora de pulsar sobre una carta ya hay previamente una boca arriba o no.</remarks>
    Public mostrada As Boolean
    ''' <summary>
    ''' Variable lastOption.
    ''' </summary>
    ''' <remarks>Variable entera que se encargará de comparar si dos cartas son iguales o no por medio de su Tag.</remarks>
    Public lastoption As Integer
    ''' <summary>
    ''' Botón lastControl.
    ''' </summary>
    ''' <remarks>Botón que va a almacenar la información del penúltimo botón que ha pulsado el usuario.</remarks>
    Public lastControl As Button
    ''' <summary>
    ''' Botón actualControl.
    ''' </summary>
    ''' <remarks>Botón que se encargará de almacenar el botón que acaba de pulsar el usuario por última vez, que será el correspondiente al que venga del evento click que convenga.</remarks>
    Public actualControl As Button
    ''' <summary>
    ''' Array tablero.
    ''' </summary>
    ''' <remarks>
    ''' Array de Figuras que se va a encargar de guardar las 12 figuras que pertenecen al juego.
    ''' Este tablero se inicializará aleatoriamente tras cada partida por medio de la función inicializarTablero()
    ''' </remarks>
    Public tablero() As Figuras = {Figuras.abe, Figuras.abe, Figuras.bart, Figuras.bart, Figuras.homer, Figuras.homer, Figuras.lisa, Figuras.lisa, Figuras.maggie, Figuras.maggie, Figuras.marge, Figuras.marge}
    ''' <summary>
    ''' Variable record.
    ''' </summary>
    ''' <remarks>Variable entera que va a almacenar el record de intentos de cada ronda y se encargará de compararlo con el que es actualmente el mejor record para saber si éste es ahora el mejor.</remarks>
    Public record As Integer
    ''' <summary>
    ''' Variable recordMax.
    ''' </summary>
    ''' <remarks>
    ''' Variable entera que almacenará la mejor partida en función del númeor de intentos. 
    ''' Inicialmente se inicializará a un número muy grande para que así en la primera partida se guarde el primer record en la aplicación.
    ''' </remarks>
    Public recordMax As Integer
    ''' <summary>
    ''' Evento load del formulario frm_memory.
    ''' </summary>
    ''' <remarks>El formulario cargará cada vez que sea ejecutado cada una de las cartas boca abajo, llamará a los métodos inicializarTablero() e insertarImagen() e inicializará las variables recordMax, mostrada y la etiqueta lbl_intentos.</remarks>
    Private Sub frm_memory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objeto As Control
        Try
            For Each objeto In Me.Controls
                If TypeOf objeto Is Button Then
                    objeto.Visible = True
                End If
            Next
            inicializarTablero()
            insertarImagen()
            recordMax = 500
            mostrada = False
            Me.lbl_intentos.Text = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Evento tick del timer1.
    ''' </summary>
    ''' <remarks>
    ''' Evento tick del timer que tendrá por función mantener dos cartas boca arriba durante unos milisegundos, en caso de no ser iguales, y ocultarlas pasado ese tiempo. 
    ''' Contendrá también las llamadas a la función bloqueaCartas().
    ''' </remarks>
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Me.lastControl.Visible = True
            bloquearCartas(True)
            Me.Timer1.Stop()
            mostrada = False
            Me.actualControl.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Evento click del botón btn_1
    ''' </summary>
    ''' <remarks>Su función será pasarle al método juego() el botón que provocó su evento click así como el pictureBox que alberga debajo.</remarks>
    Private Sub btn_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_1.Click
        juego(sender, Me.pbx_1)
    End Sub
    ''' <summary>
    ''' Evento click del botón btn_2
    ''' </summary>
    ''' <remarks>Su función será pasarle al método juego() el botón que provocó su evento click así como el pictureBox que alberga debajo.</remarks>
    Private Sub btn_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_2.Click
        juego(sender, Me.pbx_2)
    End Sub
    ''' <summary>
    ''' Evento click del botón btn_3
    ''' </summary>
    ''' <remarks>Su función será pasarle al método juego() el botón que provocó su evento click así como el pictureBox que alberga debajo.</remarks>
    Private Sub btn_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_3.Click
        juego(sender, Me.pbx_3)
    End Sub
    ''' <summary>
    ''' Evento click del botón btn_4
    ''' </summary>
    ''' <remarks>Su función será pasarle al método juego() el botón que provocó su evento click así como el pictureBox que alberga debajo.</remarks>
    Private Sub btn_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_4.Click
        juego(sender, Me.pbx_4)
    End Sub
    ''' <summary>
    ''' Evento click del botón btn_5
    ''' </summary>
    ''' <remarks>Su función será pasarle al método juego() el botón que provocó su evento click así como el pictureBox que alberga debajo.</remarks>
    Private Sub btn_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_5.Click
        juego(sender, Me.pbx_5)
    End Sub
    ''' <summary>
    ''' Evento click del botón btn_6
    ''' </summary>
    ''' <remarks>Su función será pasarle al método juego() el botón que provocó su evento click así como el pictureBox que alberga debajo.</remarks>
    Private Sub btn_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_6.Click
        juego(sender, Me.pbx_6)
    End Sub
    ''' <summary>
    ''' Evento click del botón btn_7
    ''' </summary>
    ''' <remarks>Su función será pasarle al método juego() el botón que provocó su evento click así como el pictureBox que alberga debajo.</remarks>
    Private Sub btn_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_7.Click
        juego(sender, Me.pbx_7)
    End Sub
    ''' <summary>
    ''' Evento click del botón btn_8
    ''' </summary>
    ''' <remarks>Su función será pasarle al método juego() el botón que provocó su evento click así como el pictureBox que alberga debajo.</remarks>
    Private Sub btn_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_8.Click
        juego(sender, Me.pbx_8)
    End Sub
    ''' <summary>
    ''' Evento click del botón btn_9
    ''' </summary>
    ''' <remarks>Su función será pasarle al método juego() el botón que provocó su evento click así como el pictureBox que alberga debajo.</remarks>
    Private Sub btn_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_9.Click
        juego(sender, Me.pbx_9)
    End Sub
    ''' <summary>
    ''' Evento click del botón btn_10
    ''' </summary>
    ''' <remarks>Su función será pasarle al método juego() el botón que provocó su evento click así como el pictureBox que alberga debajo.</remarks>
    Private Sub btn_10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_10.Click
        juego(sender, Me.pbx_10)
    End Sub
    ''' <summary>
    ''' Evento click del botón btn_11
    ''' </summary>
    ''' <remarks>Su función será pasarle al método juego() el botón que provocó su evento click así como el pictureBox que alberga debajo.</remarks>
    Private Sub btn_11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_11.Click
        juego(sender, Me.pbx_11)
    End Sub
    ''' <summary>
    ''' Evento click del botón btn_12
    ''' </summary>
    ''' <remarks>Su función será pasarle al método juego() el botón que provocó su evento click así como el pictureBox que alberga debajo.</remarks>
    Private Sub btn_12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_12.Click
        juego(sender, Me.pbx_12)
    End Sub
    ''' <summary>
    ''' Método inicializarTablero()
    ''' </summary>
    ''' <remarks>
    ''' Método sub que no recibe parámetros.
    ''' La función de este método será la de inicializar aleatoriamente el tablero en cada partida. Esto se hará colocando las 12 figuras disponibles sobre el array tablero de forma aleatoria, 
    ''' generando los números aleatorios que se necesiten para rellenar la tabla y apoyándonos en una tabla de booleans, que nos indicará si la posición del array asociada al número aleatorio correspondiente está ya ocupada por una figura o no.
    ''' </remarks>
    Private Sub inicializarTablero()
        Dim i, num As Integer
        Dim rellenado As Boolean = False
        Dim esValido(11) As Boolean
        Dim aleatorio As New System.Random
        Try
            For i = 0 To esValido.GetUpperBound(0)
                esValido(i) = True
            Next
            i = 0
            While Not rellenado
                num = aleatorio.Next(0, 12)
                Select Case num
                    Case 0
                        If esValido(0) = True Then
                            tablero(i) = Figuras.abe
                            esValido(0) = False
                            i += 1
                        End If
                    Case 1
                        If esValido(1) = True Then
                            tablero(i) = Figuras.abe
                            esValido(1) = False
                            i += 1
                        End If
                    Case 2
                        If esValido(2) = True Then
                            tablero(i) = Figuras.bart
                            esValido(2) = False
                            i += 1
                        End If
                    Case 3
                        If esValido(3) = True Then
                            tablero(i) = Figuras.bart
                            esValido(3) = False
                            i += 1
                        End If
                    Case 4
                        If esValido(4) = True Then
                            tablero(i) = Figuras.homer
                            esValido(4) = False
                            i += 1
                        End If
                    Case 5
                        If esValido(5) = True Then
                            tablero(i) = Figuras.homer
                            esValido(5) = False
                            i += 1
                        End If
                    Case 6
                        If esValido(6) = True Then
                            tablero(i) = Figuras.lisa
                            esValido(6) = False
                            i += 1
                        End If
                    Case 7
                        If esValido(7) = True Then
                            tablero(i) = Figuras.lisa
                            esValido(7) = False
                            i += 1
                        End If
                    Case 8
                        If esValido(8) = True Then
                            tablero(i) = Figuras.maggie
                            esValido(8) = False
                            i += 1
                        End If
                    Case 9
                        If esValido(9) = True Then
                            tablero(i) = Figuras.maggie
                            esValido(9) = False
                            i += 1
                        End If
                    Case 10
                        If esValido(10) = True Then
                            tablero(i) = Figuras.marge
                            esValido(10) = False
                            i += 1
                        End If
                    Case 11
                        If esValido(11) = True Then
                            tablero(i) = Figuras.marge
                            esValido(11) = False
                            i += 1
                        End If
                End Select
                If i = 12 Then
                    rellenado = True
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Método insertarImagen()
    ''' </summary>
    ''' <remarks>
    ''' Método sub que no recibe parámetros.
    ''' 
    ''' Esta función tiene por objetivo asociar a cada pictureBox su imagen (que está cargada como recurso al proyecto) y un tag, usado posteriormente para las comparaciones de dos cartas, de acuerdo con la figura de su tablero.
    ''' </remarks>
    Private Sub insertarImagen()
        Dim i As Integer
        Dim objeto As Control
        Dim boton As PictureBox
        Try
            For Each objeto In Me.Controls
                If TypeOf objeto Is PictureBox Then 'si ese control del tablero es un picturebox
                    boton = objeto
                    Select Case tablero(i)
                        Case Figuras.abe
                            boton.Image = My.Resources.abe
                            boton.Tag = 1
                        Case Figuras.bart
                            boton.Image = My.Resources.bart
                            boton.Tag = 2
                        Case Figuras.homer
                            boton.Image = My.Resources.homer
                            boton.Tag = 3
                        Case Figuras.lisa
                            boton.Image = My.Resources.lisa
                            boton.Tag = 4
                        Case Figuras.maggie
                            boton.Image = My.Resources.maggie
                            boton.Tag = 5
                        Case Figuras.marge
                            boton.Image = My.Resources.marge
                            boton.Tag = 6
                    End Select
                    i += 1
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Método bloquearCartas()
    ''' </summary>
    ''' <remarks>
    ''' Recibe como parámetro un boolean.
    ''' 
    ''' Método que se encarga de bloquear las cartas del tablero durante un instante cuando dos cartas estén boca arriba listas para ser comparadas, para de esta manera impedir al usuario que pulse una tercera carta mentras se comparan esas 2.
    ''' El boolean que se recibe por parámetro determinará cuando se bloquea/desbloquea el tablero.
    ''' </remarks>
    Private Sub bloquearCartas(ByVal b As Boolean)
        Dim objeto As Control
        Try
            For Each objeto In Me.Controls
                If TypeOf objeto Is Button Then
                    objeto.Enabled = b
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Método juego()
    ''' </summary>
    ''' <remarks>
    ''' Método sub que recibe como parámetro un botón y un pictureBox.
    ''' Método principal de la aplicación que será la encargada de comparar las cartas, de visualizarlas al usuario, de activar el timer y de controlar los intentos y los records de cada partida del usuario.
    ''' </remarks>
    Private Sub juego(ByVal boton As Button, ByVal dibujo As PictureBox)
        Try
            Me.actualControl = boton
            If mostrada = True Then 'si hay alguna boca arriba.
                If lastoption = dibujo.Tag Then 'si es igual a la que está boca arriba: acierta.
                    Me.actualControl.Visible = False
                    mostrada = False
                    Me.lbl_intentos.Text += 1
                Else                            'si no es igual: falla
                    lastoption = dibujo.Tag
                    Me.actualControl.Visible = False
                    bloquearCartas(False)
                    Me.Timer1.Start()
                    Me.lbl_intentos.Text += 1
                End If
            Else
                mostrada = True 'no hay ninguna boca arriba aún.
                Me.actualControl.Visible = False
                lastoption = dibujo.Tag
                Me.lastControl = Me.actualControl
            End If
            If Me.lbl_intentos.Text > 0 AndAlso btn_1.Visible = False AndAlso btn_2.Visible = False AndAlso btn_3.Visible = False AndAlso btn_4.Visible = False AndAlso btn_5.Visible = False AndAlso btn_6.Visible = False AndAlso btn_7.Visible = False AndAlso btn_8.Visible = False AndAlso btn_9.Visible = False AndAlso btn_10.Visible = False AndAlso btn_11.Visible = False AndAlso btn_12.Visible = False Then
                MsgBox("Enhorabuena, has ganado el juego en " + Me.lbl_intentos.Text + " intentos!")
                record = Me.lbl_intentos.Text
                If recordMax > record Then
                    MsgBox("Y además has conseguido un nuevo record!")
                    Me.MejorRecordToolStripMenuItem.Text = "El record actualmente está en " & record & " intentos."
                    recordMax = record
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Evento click del NuevaPartidaToolStripMenuItem.
    ''' </summary>
    ''' <remarks>
    ''' Se encargará de iniciar una nueva partida.
    ''' Pondrá todas las cartas del tablero boca abajo y llamará a los métodos inicializarTablero() e insertarImagen() y reestablecerá el contador de intentos a 0.
    ''' </remarks>
    Private Sub NuevaPartidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaPartidaToolStripMenuItem.Click
        Dim objeto As Control
        Try
            For Each objeto In Me.Controls
                If TypeOf objeto Is Button Then
                    objeto.Visible = True
                End If
            Next
            inicializarTablero()
            insertarImagen()
            mostrada = False
            Me.lbl_intentos.Text = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Evento click del SalirToolStripItem.
    ''' </summary>
    ''' <remarks>Sale de la aplicación actual.</remarks>
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
