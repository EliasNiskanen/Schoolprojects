import { Component, useState } from 'react';
import Lisays from './Lisays';
import Button from 'react-bootstrap/Button';
import 'bootstrap/dist/css/bootstrap.min.css'


class Hyllyt extends Component {

    constructor(props) {
        super();

        this.buttonClicked = this.buttonClicked.bind(this);
        this.poista = this.poista.bind(this);
        this.plus = this.plus.bind(this);
        this.miinus = this.miinus.bind(this);


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
           

           //alla oleva koodipätkä kopsattu netistä. käsketään odottaa hetken ennen kuin päivitetään sivu
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

        

        let response = await fetch("http://localhost:4000/Hyllyt");
        let data = await response.json();

        this.setState({ data: data });
        console.log(data.id);

    }
    async plus(event){
        await fetch('http://localhost:4000/Tavara/Hyllyt' +  event.target.id, {
            method: 'PUT',
            body: JSON.stringify({
            kpl : this.state.Tavara.kpl +1

            })

                
          })
        console.log(this.state.Tavara.kpl)
        this.fetchData();
    }
    
    async miinus(event){
        await fetch('http://localhost:4000/Hyllyt/' +  event.target.id, {
            method: 'PUT',
            body: JSON.stringify({
            kpl : this.state.Tavara.kpl -1

            })

                
          })
        console.log(this.state.Tavara.kpl)
        this.fetchData();
    }


        

    render() {

        

        if (this.state.data == null)

            return (
                <div>
                   
{/*                     <form>
                    <Lisays/>
                        <label>

                        Name:&nbsp;
                            <input id="etsinimi" type="texbox" defaultValue={this.state.nimi} />

                            <p>Osoite:&nbsp;

                                <input id="etsiosoite" type="texbox" />

                            </p>
                            
                        </label>
                       
                    </form>

                        <button onClick={this.buttonClicked} id="etsinappi">Etsi</button> */}

                        <p>Loading....</p>

                </div>

            )
            else if (this.state.data.length === 0){

                return(
            <div>
                   
            <form>
                <label>

                Name:&nbsp;
                    <input id="etsinimi" type="texbox" defaultValue={this.state.nimi} />

                    <p>Osoite:&nbsp;

                        <input id="etsiosoite" type="texbox" />

                    </p>
                    
                </label>
               
            </form>

                <Button variant="primary" onClick={this.buttonClicked} id="etsinappi">Etsi</Button>
                <Button variant="primary" onClick={this.buttonClicked} id="etsinappi">Post</Button>
                <p>Annetuilla hakuehdoilla ei löytynyt dataa</p>

        </div>
                )
            }
        else {
            


           let dataObjektit = this.state.data.map((Hylly) =>
         
      
                <tr key={Hylly.id}>

                    <td>{Hylly.id}</td>
                    <td>{Hylly.Nimi}</td>  
                    <td>{Hylly.Lisätieto}</td> 
                  
                   {/*  <td>{tuote.Hyllynumero}</td>  */}
            
                    
        




                        <td>

                    <Button variant='secondary' onClick={this.poista} id={Hylly.id}> Poista</Button>
                    </td>
                
                </tr>

            );
                          console.log(dataObjektit) 

            return (

                <div>
                  {/*   <form>
 

                        <label>

                            Name:&nbsp;
                            <input id="etsinimi" type="texbox" defaultValue={this.state.nimi} />

                            <p>Osoite:&nbsp;

                                <input id="etsiosoite" type="texbox" />

                            </p>
                            
    
                        </label>
                    </form>

                    <p><button onClick={this.buttonClicked} id="etsinappi">Etsi</button> </p> */}
                
                    <table>
                        <tbody>

                            <tr>
                            <th>Hylly id</th>
                            <th>Nimi</th>
                            <th>Lisätieto</th>

                         
                            
                            <th>Poista</th>
                            </tr>
                            {dataObjektit}

                        </tbody>
                    </table>
                    <div>
                    </div>
                </div>

            )

        }
    }
}

export default Hyllyt




