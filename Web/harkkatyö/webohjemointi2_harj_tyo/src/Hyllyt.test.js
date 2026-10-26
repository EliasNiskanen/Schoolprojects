import { render, screen } from '@testing-library/react';
import Hyllyt from './Hyllyt';


describe("Yksinkertainen testi yksinkertaiselle palikalle", ()=>{
    test("Renderöidään komponentti ja tarkistetaan, että se näyttää halutulta", ()=>{
        render(<Hyllyt/>); // renderöidään komponentti
        expect(screen.getByText('Loading....')).toBeInTheDocument();
    })
})