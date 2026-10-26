import { Component, useState } from 'react';
import Lisays from './Lisays';
import Button from 'react-bootstrap/Button';
import 'bootstrap/dist/css/bootstrap.min.css';
import Table from 'react-bootstrap/Table';


class Tuotteet extends Component {

    constructor(props) {
        super();

        this.buttonClicked = this.buttonClicked.bind(this);
        this.poista = this.poista.bind(this);
    


        this.state = {
            data: null,
            enimi: "",
            eosoite: "",
            kpl: 0

        }  
        
    }

     async buttonClicked() {   //etsi toiminto

        

        this.setState({
            
            data: null,
            id: document.getElementById("id").value,
            nimi: document.getElementById("nimi").value,
            kpl: document.getElementById("kpl").value

        })
    
        
       await this.fetchData();
    }

    async poista(event) {  //poista toiminto

        
       // alert("Poistettu "+ event.target.enimi);
        
         fetch('http://localhost:4000/Tavara/' +  event.target.id, {
            method: 'DELETE',
          })

           this.fetchData();
           

           
          setTimeout(function() { //Start the timer     
            this.setState({render: true}) //After 1 second, set render to true
        }.bind(this), 500)

         // await this.buttonClicked()
         this.fetchData();
    }

    


    componentDidMount() {

        this.fetchData();

    }

    async fetchData() {

        

        let response = await fetch("http://localhost:4000/Tavara");
        let data = await response.json();

        this.setState({ data: data });
        console.log(data.id);

    }

    render() {

        

        if (this.state.data == null)

            return (
                <div>
                   


                        <p>Loading....</p>{/*  näyttää latauruudun */}

                </div>

            )
            else if (this.state.data.length === 0){

                return(
        
                <p>Annetuilla hakuehdoilla ei löytynyt dataa</p>

   
                )
            }
        else {
            <Lisays/>


           let dataObjektit = this.state.data.map((tuote) =>  /* haetaan tiedot json serverilta */
         
      
                <tr key={tuote.id}>

                    <td>{tuote.id}</td>
                    <td>{tuote.Nimitys}</td>  
                  
                    <td>{tuote.kpl}</td>
                    <td>{tuote.Hyllynumero}</td>
                    
                        <td>

                    <Button variant='secondary' onClick={this.poista} id={tuote.id}> Poista</Button>
                    </td>
                
                </tr>

            );
                          console.log(dataObjektit) 

            return (

                <div>
  
                    
                    <Lisays/>           {/* LUODAAN TAULUKKO */}
                    <Table striped bordered hover size="lg">
                        <tbody>

                            <tr>
                            <th>Tuote id</th>
                            <th>Tuote nimitys</th>
                          
                            <th>kpl</th>
                            
                            <th>Hyllynumero</th>
                            <th>Poista</th>
                        
                            </tr>
                            {dataObjektit}

                        </tbody>
                    </Table>
                    <div>
                    </div>
                </div>

            )

        }
    }
}

export default Tuotteet




