import { Component} from "react";

class Search extends Component{


    /*Hakukentässä pieniä lapsuuksia mutta ei anneta sen haitata, viesti palautuu myös jos ei ole dataa mitä näyttää mutta silloin pitää mennä uudelleen hakukenttään,
     ja sieltä kumitella pois, hakukentässä on muutenkin ihmeellinen lapsuus jota en enää näin sunnuntai iltana alkanut kikkailemaan, 
     eli jostain syystä ei tavallaan ota jokaista merkkiä vastaan, ja toimii siis vain nimellä.
     Uskoisin että on siis railusti yli 40% 8-12 tehtävistä tässä. En lähtenyt turhaan edes yrittämään 13-14 tehtäviä mielenterveyteni säästämiseksi. 
     Kiitos ja anteeksi!*/

    constructor(props){

        super();

        this.deleteUser = this.deleteUser.bind(this)
        this.searchData = this.searchData.bind(this)


        this.state = {
            data:null,
            value: '',
        }

    }

    componentDidMount(){
        this.fetchData();
        this.searchData();
    }

    async fetchData(){

            let response = await fetch("http://localhost:4000/Asiakkaat");
            let data = await response.json();
            console.log(data)
            this.setState({data:data});
    }
    
    async searchData(event) {
    this.setState({value: event.target.value});
    let response = await fetch("http://localhost:4000/asiakkaat?nimi_like="+this.state.value +"&osoite_like=");
    let data = await response.json(this.state.value);
    console.log(this.state.value)
    console.log(data)
    this.setState({data:data});
    }

    async deleteUser(id){
        let response = await fetch("http://localhost:4000/Asiakkaat/"+id, {
            method: 'DELETE', 
            headers: {
                'Accept': 'application/json', 'Content-type':'application/json'}, 
            body:null})
        .then((response)=>{
        console.log(response);
        this.fetchData()
        })
    }

    render(){
            if(this.state.data == null)
                return(
                    <div>
                    <p> loading...</p>        
                    </div>
                )
            else if(this.state.data.length == 0) {
                return(
                    <div>                    
                        <p>hakukenttä</p>
                        <input type="text" value={this.state.value} onChange={this.searchData} />
                        <p>Annetuilla hakuehdoilla ei löytynyt dataa</p>
                    </div>
                )
            }
            else{                    
                return(
                    <>
                    <p>hakukenttä</p>
                    <input type="text" value={this.state.value} onChange={this.searchData} />
                        <table>
                            <tbody>
                                <tr>
                                    <td>
                                        id
                                    </td>
                                    <td>
                                        nimi
                                    </td>
                                    <td>
                                        puhelinnumero
                                    </td>
                                    <td>
                                        osoite
                                    </td>
                                    <td>
                                        postinumero
                                    </td>
                                    <td>
                                        postitoimipaikka
                                    </td>
                                </tr>
                                {
                                    this.state.data.map((asiakas)=>
                                    <>
                                    <tr>
                                    <td key={asiakas.id}>{asiakas.id}</td>
                                    <td>{asiakas.nimi}</td>
                                    <td>{asiakas.puhelinnumero}</td>
                                    <td>{asiakas.osoite}</td>
                                    <td>{asiakas.postinumero}</td>
                                    <td>{asiakas.postitoimipaikka}</td>
                                    <td><button onClick={()=>this.deleteUser(asiakas.id)}>delete</button></td>
                                    </tr>
                                    </>
                                    )
                                }
                            </tbody>
                        </table>
                    </>
                )
            }
            
    }

}

export default Search