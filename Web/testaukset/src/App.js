import logo from './logo.svg';
import './App.css';
import Nappi from './Nappi';
import Elainlista from './Elainlista';
import DataTable from './DataTable'

/* nämä pitäisi riittää että ohjelma toimii: 
npx json-server db.json --watch --port 4000
npm install axios */


function App() {
  return (
    <div className="App">
      <Elainlista/>
      <Nappi/>
      <DataTable/>
    </div>
  );
}

export default App;
