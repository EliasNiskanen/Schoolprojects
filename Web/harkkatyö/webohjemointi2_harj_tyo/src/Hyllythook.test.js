import { render, screen } from '@testing-library/react';
import Hyllythook from './Hyllythook';


describe("Yksinkertainen testi yksinkertaiselle palikalle", ()=>{
    test("Renderöidään komponentti ja tarkistetaan, että se näyttää halutulta", ()=>{
        render(<Hyllythook/>); // renderöidään komponentti
        expect(screen.getByText('Loading...')).toBeInTheDocument();
    })
})