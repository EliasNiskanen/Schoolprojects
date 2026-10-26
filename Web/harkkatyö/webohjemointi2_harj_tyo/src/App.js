import './App.css';

import Hyllyt from './Hyllyt';
import Lisays from './Lisays';

import { Link, Outlet } from 'react-router-dom';
import 'bootstrap/dist/css/bootstrap.min.css'


  //npx json-server db.json --watch --port 4000

function App() {

    
  return (
    <div className="App">
      <header className="App-header">

        <p>
          WEB2 harjoitustyö
        
     
          <nav>

              
          
            [<Link to="/Hyllythook">Hyllyt</Link>]

            [<Link to="/Tuotteet">Tuotteet</Link>]

            [<Link to="Muokkaus">Muokkaa tuotteita</Link>]
          </nav>
          <Outlet/>
         

        
          
            </p>
  
            
      </header>

      
    </div>
  );
}

export default App;
