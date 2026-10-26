import React, { Component } from 'react'
import './App.css'

class Nappi extends Component{
  
    constructor(props){
        super(props);
        this.state = {
            value: 0

        }
        this.buttonClicked = this.buttonClicked.bind(this);
    }
    Reset(){
        this.setState({
            value : this.state.value=0
        })

    }
    buttonClicked(event){
        

        this.setState({
            value : this.state.value+1 
            
        });
        if(this.state.value > 9)
            this.setState({
                    vari: "red",
                    tyyli: "italic"
            })

    }
    Reset = () => {
        this.setState({value: 0, 
        vari: null,
        tyyli: null})

    }

    render(){ 

        var vari = this.state.vari;
        var tyyli = this.state.tyyli;

        return (
            <div>
                <div>
                    <button data-testid={"btn1"} style={{backgroundColor:vari,fontStyle:tyyli}} onClick = {this.buttonClicked}>Paina tätä</button>
                    <button data-testid={"btn2"} onClick = {this.Reset}>Reset</button>
                    <div>
                       Klikattu {this.state.value} kertaa
                    </div>
                </div>
            </div>
        )
    }
}

export default Nappi