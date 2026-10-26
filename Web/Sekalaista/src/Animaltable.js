import { Component } from "react";



class animalTable extends Component {
   constructor(props) {
      super(props) //since we are extending class Table so we have to use super in order to override Component class constructor
      this.state = { //state is by default an object
         animals: [
            {  name: 'Kolli', owner: "Matti Meikäläinen", year: 1999, breed: "Siamese" },
            {  name: 'Kolli', owner: "Matti Meikäläinen", year: 1999, breed: "Siamese" },
            {  name: 'Kolli', owner: "Matti Meikäläinen", year: 1999, breed: "Siamese" },
            {  name: 'Kolli', owner: "Matti Meikäläinen", year: 1999, breed: "Siamese" },
            {  name: 'Kolli', owner: "Matti Meikäläinen", year: 1999, breed: "Siamese" },
           
            
          
         ]
      }
   }


   renderTableData() {
    return this.state.animals.map((animals, index) => {
       const { name, owner, year, breed } = animals//destructuring
       return (
        <table>
        
        <tr>
             <td>{name}</td>
             <td>{owner}</td>
             <td>{year}</td>
             <td>{breed}</td>
             </tr>
          </table>
       )
    })
 }

 render() {
    return (
       <div>

          <table id='animals' className="table">
             <tbody>
                {this.renderTableData()}
             </tbody>
          </table>
       </div>
    )
 }
}

export default animalTable //exporting a component make it reusable and this is the beauty of react