namespace App7

open System

open Android.App
open Android.Content
open Android.OS
open Android.Runtime
open Android.Views
open Android.Widget

type Resources = App7.Resource

[<Activity (Label = "App7", MainLauncher = true, Icon = "@mipmap/icon")>]
type MainActivity () =
    inherit Activity ()

    
    let mutable n = 0
    let mutable n0 = 0
    let mutable nn = 0
    let mutable nnn = 0
    let mutable nnnn = 0
    let mutable nn1 = 0
    let mutable nnn1 = 0
    let mutable nnnn1 = 0
    let mutable linha = ""
    
    override this.OnCreate (bundle) =

        base.OnCreate (bundle)
        // Set our view from the "main" layout resource
        this.SetContentView (Resources.Layout.Main)

        // Get our button from the layout resource, and attach an event to it
        let button = this.FindViewById<Button>(Resources.Id.myButton)
        let text1 = this.FindViewById<TextView>(Resources.Id.textView2)
        let text2 = this.FindViewById<TextView>(Resources.Id.textView3)
        let text3 = this.FindViewById<TextView>(Resources.Id.textView4)
        let text4 = this.FindViewById<TextView>(Resources.Id.textView5)
        let text5 = this.FindViewById<TextView>(Resources.Id.textView6)
        let text6 = this.FindViewById<TextView>(Resources.Id.textView7)
        let text7 = this.FindViewById<TextView>(Resources.Id.textView8)
        let edit = this.FindViewById<EditText>(Resources.Id.editText1)
        let edit0 = this.FindViewById<EditText>(Resources.Id.edit1)
        let radg0 = this.FindViewById<RadioGroup>(Resources.Id.radg1)
        let radb1 = this.FindViewById<RadioButton>(Resources.Id.rad1)
        let radb2 = this.FindViewById<RadioButton>(Resources.Id.rad2)
        let radb3 = this.FindViewById<RadioButton>(Resources.Id.rad3)
        let radb4 = this.FindViewById<RadioButton>(Resources.Id.rad4)
        let radb5 = this.FindViewById<RadioButton>(Resources.Id.rad5)
        let radb9 = this.FindViewById<RadioButton>(Resources.Id.rad9)
        
        radg0.CheckedChange.Add(fun args -> 
           let selectedId = radg0.CheckedRadioButtonId
           let selectedRadio = radg0.FindViewById<RadioButton>(selectedId)
           let mutable radselected = selectedRadio.Text
           Toast.MakeText(this,sprintf "%s selecionada" radselected, ToastLength.Short).Show()
           linha <- radselected
           match linha with
           | "L1" -> button.Click.Add (fun args -> 
               let  txts = edit.Text
               match System.Int32.TryParse(txts) with
               | (true, valor) -> 
                  n <- valor
                  nn <- n / 16
                  nn1 <- (n - n0) / 16
                  nnn <- (nn1 * 60) / 2625 - 60
                  nnn1 <- (nn * 720) / 31500 - 720
                  nnnn <- (nn1 * 100) / 2625
                  nnnn1 <- (nn * 100) / 31500
                  text1.Text <- sprintf "Caixas: %d" nn1
                  text2.Text <- sprintf "Total Caixas: %d" nn
                  text3.Text <- sprintf "Tempo perdido: %d min." nnn
                  text4.Text <- sprintf "Perdido Total: %d min." nnn1
                  text5.Text <- sprintf "Percentagem Hora: %d %%" nnnn
                  text6.Text <- sprintf "Percentagem Total: %d %%" nnnn1
                  edit0.Text <- sprintf "Contador: %d  \n %d cxs \n TP: %d min. " n nn1 nnn
                  n0 <- n 
               | (false, valor) ->
                  n <- 0
                )
           | "L2" -> button.Click.Add (fun args -> 
               let  txts = edit.Text
               match System.Int32.TryParse(txts) with
               | (true, valor) -> 
                  n <- valor
                  nn <- n / 4
                  nn1 <- (n - n0) / 4
                  nnn <- (nn1 / 18) - 60
                  nnn1 <- (nn / 18) - 720
                  nnnn <- (nn1 * 100) / 1125
                  nnnn1 <- (nn * 100) / 13500
                  let mutable palete = nn / 48
                  let mutable paletee = nn /36
                  text1.Text <- sprintf "Caixas: %d" nn1
                  text2.Text <- sprintf "Total Caixas: %d" nn
                  text3.Text <- sprintf "Tempo perdido: %d min." nnn
                  text4.Text <- sprintf "Perdido Total: %d min." nnn1
                  text5.Text <- sprintf "Percentagem Hora: %d %%" nnnn
                  text6.Text <- sprintf "Percentagem Total: %d %%" nnnn1
                  text7.Text <- sprintf "Paletes:US/EUR = %d/%d" palete paletee
                  edit0.Text <- sprintf "Contador: %d  \n %d cxs \n TP: %d min. " n nn1 nnn
                  n0 <- n 
               | (false, valor) ->
                  n <- 0  
               ) 
           | "L3" -> button.Click.Add (fun args -> 
               let  txts = edit.Text
               match System.Int32.TryParse(txts) with
               | (true, valor) -> 
                  n <- valor
                  nn <- n / 8
                  nn1 <- (n - n0) / 8
                  nnn <- (nn1 * 60) / 4500 - 60
                  nnn1 <- (nn * 720) / 54000 - 720
                  nnnn <- (nn1 * 100) / 4500
                  nnnn1 <- (nn * 100) / 54000
                  text1.Text <- sprintf "Caixas: %d" nn1
                  text2.Text <- sprintf "Total Caixas: %d" nn
                  text3.Text <- sprintf "Tempo perdido: %d min." nnn
                  text4.Text <- sprintf "Perdido Total: %d min." nnn1
                  text5.Text <- sprintf "Percentagem Hora: %d %%" nnnn
                  text6.Text <- sprintf "Percentagem Total: %d %%" nnnn1
                  edit0.Text <- sprintf "Contador: %d  \n %d cxs \n TP: %d min. " n nn1 nnn
                  n0 <- n 
               | (false, valor) ->
                  n <- 0  
               )
           | "L4" -> button.Click.Add (fun args -> 
               let  txts = edit.Text
               match System.Int32.TryParse(txts) with
               | (true, valor) -> 
                  n <- valor
                  nn <- n / 24
                  nn1 <- (n - n0) / 24
                  nnn <- (nn1 * 60) / 1750 - 60
                  nnn1 <- (nn * 720) / 21000 - 720
                  nnnn <- (nn1 * 100) / 1750
                  nnnn1 <- (nn * 100) / 21000
                  text1.Text <- sprintf "Caixas: %d" nn1
                  text2.Text <- sprintf "Total Caixas: %d" nn
                  text3.Text <- sprintf "Tempo perdido: %d min." nnn
                  text4.Text <- sprintf "Perdido Total: %d min." nnn1
                  text5.Text <- sprintf "Percentagem Hora: %d %%" nnnn
                  text6.Text <- sprintf "Percentagem Total: %d %%" nnnn1
                  edit0.Text <- sprintf "Contador: %d  \n %d cxs \n TP: %d min. " n nn1 nnn
                  n0 <- n 
               | (false, valor) ->
                  n <- 0 
               )
           | "L5" -> button.Click.Add (fun args -> 
               let  txts = edit.Text
               match System.Int32.TryParse(txts) with
               | (true, valor) -> 
                  n <- valor
                  nn <- n / 4
                  nn1 <- (n - n0) / 4
                  nnn <- (nn1 / 18) - 60
                  nnn1 <- (nn / 18) - 720
                  nnnn <- (nn1 * 100) / 1125
                  nnnn1 <- (nn * 100) / 13500
                  text1.Text <- sprintf "Caixas: %d" nn1
                  text2.Text <- sprintf "Total Caixas: %d" nn
                  text3.Text <- sprintf "Tempo perdido: %d min." nnn
                  text4.Text <- sprintf "Perdido Total: %d min." nnn1
                  text5.Text <- sprintf "Percentagem Hora: %d %%" nnnn
                  text6.Text <- sprintf "Percentagem Total: %d %%" nnnn1
                  edit0.Text <- sprintf "Contador: %d  \n %d cxs \n TP: %d min. " n nn1 nnn
                  n0 <- n 
               | (false, valor) ->
                  n <- 0
                )
           | "L9" -> button.Click.Add (fun args -> 
               let  txts = edit.Text
               match System.Int32.TryParse(txts) with
               | (true, valor) -> 
                  n <- valor
                  nn <- n / 24
                  nn1 <- (n - n0) / 24
                  nnn <- (nn1 * 60) / 3333 - 60
                  nnn1 <- (nn * 720) / 40000 - 720
                  nnnn <- (nn1 * 100) / 3333
                  nnnn1 <- (nn * 100) / 40000
                  text1.Text <- sprintf "Caixas: %d" nn1
                  text2.Text <- sprintf "Total Caixas: %d" nn
                  text3.Text <- sprintf "Tempo perdido: %d min." nnn
                  text4.Text <- sprintf "Perdido Total: %d min." nnn1
                  text5.Text <- sprintf "Percentagem Hora: %d %%" nnnn
                  text6.Text <- sprintf "Percentagem Total: %d %%" nnnn1
                  edit0.Text <- sprintf "Contador: %d  \n %d cxs \n TP: %d min. " n nn1 nnn
                  n0 <- n 
               | (false, valor) ->
                  n <- 0
               )
           | _    -> button.Click.Add (fun args -> 
               let  txts = edit.Text
               match System.Int32.TryParse(txts) with
               | (true, valor) -> 
                  n <- valor
                  nn <- n / 4
                  nn1 <- (n - n0) / 4
                  nnn <- (nn1 / 18) - 60
                  nnn1 <- (nn / 18) - 720
                  nnnn <- (nn1 * 100) / 1125
                  nnnn1 <- (nn * 100) / 13500
                  text1.Text <- sprintf "Caixas: %d" nn1
                  text2.Text <- sprintf "Total Caixas: %d" nn
                  text3.Text <- sprintf "Tempo perdido: %d min." nnn
                  text4.Text <- sprintf "Perdido Total: %d min." nnn1
                  text5.Text <- sprintf "Percentagem Hora: %d %%" nnnn
                  text6.Text <- sprintf "Percentagem Total: %d %%" nnnn1
                  edit0.Text <- sprintf "Contador: %d  \n %d cxs \n TP: %d min. " n nn1 nnn
                  n0 <- n 
               | (false, valor) ->
                  n <- 0
               )
        )
        
        
         

            
        

