import logo from './logo.svg';
import './App.css';

import React, { useState } from 'react';
import reactDOM from 'react-dom';


function App() {

  const[count, setCount] = useState(0);
  
  
  if (count > 10){
    const divStyle = {
      padding: '40px',
      color: 'red',
      fontStyle: 'italic'
    
    }
    return (

      <div>  
        
      <button type="button" className = "button" onClick={()=>setCount(count+1)}>Add value</button>
      <button type="button" className = "button" onClick={()=>setCount(0)}>Restart</button>
      <p div style={divStyle}>{count}</p>
  
  
      </div>
    
    
    );
  }
  
else{
  const divStyle = {
    padding: '40px',
    color: 'black',
  
  }
  return (

    <div>  
      
    <button type="button" className = "button" onClick={()=>setCount(count+1)}>Add value</button>
    <button type="button" className = "button" onClick={()=>setCount(0)}>Restart</button>
    <p div style={divStyle}>{count}</p>


    </div>
  
  
  );

}
}

reactDOM.render(<App/>, document.getElementById("root")) 
export default App;

