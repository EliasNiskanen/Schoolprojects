import { Component } from "react";



class Table extends Component {
   constructor(props) {
      super(props) //since we are extending class Table so we have to use super in order to override Component class constructor
      this.state = { //state is by default an object
         students: [
            {  name: 'Kalle', address: "Kalmankuja", year: 2020 },
          
         ]
      }
   }

   renderTableData() {
    return this.state.students.map((student, index) => {
       const { name, address, year } = student //destructuring
       return (
        <table>
        <tr>
          <th>Nimi</th>
          <th>Osoite</th>
          <th>Aloitusvuosi</th>
        </tr>
        <tr>
             <td>{name}</td>
             <td>{address}</td>
             <td>{year}</td>
             </tr>
          </table>
       )
    })
 }

 render() {
    return (
       <div>
          <h1 id='title'>React Dynamic Table</h1>
          <table id='students' className="table">
             <tbody>
                {this.renderTableData()}
             </tbody>
          </table>
       </div>
    )
 }
}

export default Table //exporting a component make it reusable and this is the beauty of react