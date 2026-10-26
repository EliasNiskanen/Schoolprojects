import {render, screen} from '@testing-library/react'
import userEvent from '@testing-library/user-event'
import Nappi from './Nappi'

describe("Testit 4-5 tehtäville", ()=> {
    render(<Nappi/>);
        test("renderöidään laskuri, tarkistetaan teksti, painetaan nappia...", async() => { 
            
            //testataan lisäys nappi.
            await userEvent.click(screen.getByTestId("btn1"))
            expect(screen.getByText("Klikattu 1 kertaa")).toBeInTheDocument();
            await userEvent.click(screen.getByTestId("btn1"));
            expect(screen.getByText("Klikattu 2 kertaa")).toBeInTheDocument();
            
            //testataan reset nappi
            await userEvent.click(screen.getByTestId("btn2"));
            expect(screen.getByText("Klikattu 0 kertaa")).toBeInTheDocument();

        })


    
})