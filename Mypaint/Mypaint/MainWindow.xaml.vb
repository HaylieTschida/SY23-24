Class MainWindow
    Private Sub DrawingCanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingCanvas.MouseMove
        If ShapeLabel.Content = "Ellipse" Then
            Dim el As New Ellipse
            el.Width = widthslider.Value
            el.Height = HightSlider.Value
            el.Fill = Colorrectangle1.Fill
            Dim p As Point = Mouse.GetPosition(DrawingCanvas)
            Canvas.SetLeft(el, p.X)
            Canvas.SetTop(el, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                drawingcanvas.Children.Add(el)
            End If
        End If
        If ShapeLabel.Content = "Rectangle" Then
            Dim el As New Rectangle
            el.Width = widthslider.Value
            el.Height = HightSlider.Value
            el.Fill = Colorrectangle1.Fill
            Dim p As Point = Mouse.GetPosition(drawingcanvas)
            Canvas.SetLeft(el, p.X)
            Canvas.SetTop(el, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                drawingcanvas.Children.Add(el)
            End If
        End If
    End Sub

    Private Sub Color2rectangle_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Colorrectangle2.MouseDown, Colorrectangle1.MouseDown, Color1rectangleRed.MouseDown, Colorrectangle3.MouseDown, Colorrectangle4.MouseDown, Colorrectangle5.MouseDown, ERASERColor.MouseDown
        Colorrectangle1.Fill = sender.fill
    End Sub

    Private Sub Clearbutton_Click(sender As Object, e As RoutedEventArgs) Handles Clearbutton.Click
        drawingcanvas.Children.RemoveRange(1, drawingcanvas.Children.Count - 1)
    End Sub

    Private Sub Undobutton_Click(sender As Object, e As RoutedEventArgs) Handles Undobutton.Click
        drawingcanvas.Children.RemoveAt(drawingcanvas.Children.Count - 1)
    End Sub

    Private Sub elipsebutton_Click(sender As Object, e As RoutedEventArgs) Handles Ellipsebutton.Click
        ShapeLabel.Content = sender.content
    End Sub

    Private Sub RectangleButton_Click(sender As Object, e As RoutedEventArgs) Handles RectangleButton.Click
        ShapeLabel.Content = sender.content
    End Sub
End Class
