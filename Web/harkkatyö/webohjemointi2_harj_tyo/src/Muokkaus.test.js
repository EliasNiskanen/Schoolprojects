import { render, screen } from '@testing-library/react';

import Muokkaus from './Muokkaus';


// beforeEach ajetaan joka kerta ennen testisarjaa
beforeEach(() => {
    jest.spyOn(global, 'fetch').mockResolvedValue({
        json: jest.fn().mockResolvedValue([{ id: 1, Nimitys: "Laatikko" }, { id: 2, nimi: "isolaatikko" }])
    })
})

// afterEach ajetaan taas joka testisarjan päätteeksi
afterEach(() => {
    jest.restoreAllMocks();
})


describe("Testit Käyttäjälistalle", ()=>{
    test("Haetaan REST-APISTA tiedot ja tarkistetaan, että ne näkyvät oikein", async ()=>{
        render(<Muokkaus/>);
        // Tarkistetaan propsit
      /*   expect(screen.getByText("Loading")).toBeInTheDocument(); */
        // Haetaan pUserit
        const items = await screen.findAllByTestId('pUser');
        expect(items).toHaveLength(2);
/*         expect(items[0].innerHTML).toBe("Laatikko");
        expect(items[1].innerHTML).toBe("isolaatikko"); */
    }) 
})
