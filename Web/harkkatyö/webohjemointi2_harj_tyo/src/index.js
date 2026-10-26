import React from 'react';

import * as ReactDOMClient from 'react-dom/client'
import {BrowserRouter, Routes, Route} from 'react-router-dom'
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';


import Tuotteet from './Tuotteet';
import Muokkaus from './Muokkaus';

import Hyllyt from './Hyllyt';
import Hyllythook from './Hyllythook';

ReactDOMClient.createRoot(document.getElementById('root')).render(
  <BrowserRouter>
   <Routes>
      <Route path="/" element={<App/>}>
        <Route path="Hyllythook" element={<Hyllythook/>}/>
        <Route path="Tuotteet" element={<Tuotteet/>}/>
        <Route path="Muokkaus" element={<Muokkaus/>}/>
        
    
    <Route path="*" element={<h1><b>Väärä reitti</b></h1>}/>
    </Route>
   </Routes>
      
  
  
  </BrowserRouter>
 
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
