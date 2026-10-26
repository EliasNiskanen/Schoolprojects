import logo from './logo.svg';

import './App.css';
  
const data = [
  { name: "Atom", ownersname: "Milla", birth: 2000 },
  { name: "Anom", ownersname: "Ella", birth: 2014 },
  { name: "Anon", ownersname: "Alli", birth: 2021 },
  { name: "Aion", ownersname: "Juuso", birth: 2009 },
]
  
function App() {
  return (
    <div className="App">
      <table>
        <tr>
          <th>Animal</th>
        </tr>
        {data.map((val, key) => {
          return (
           <li>{val.name}, {val.ownersname}, {val.birth}</li>
          )
        })}
      </table>
    </div>
  );
}
  
export default App;