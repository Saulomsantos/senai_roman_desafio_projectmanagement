import { createMaterialTopTabNavigator, createAppContainer } from 'react-navigation';

import Login from './pages/login';
import HomeAdm from './pages/homeadm';
import HomePro from './pages/homepro';
import Temas from './pages/temas';
import CadastrarProjetos from './pages/cadastrarprojetos';
import GerenciarProjetos from './pages/gerenciarprojetos';
import GerenciarTipoUsuario from './pages/gerenciartipousuario';
import CadastrarUsuario from './pages/cadastrarusuario';
import GerenciarUsuarios from './pages/gerenciarusuarios';
import Equipes from './pages/equipes';

const ProjetosNavigator = createMaterialTopTabNavigator(
    {
        Login,
        HomeAdm,
        HomePro,
        Temas,
        CadastrarProjetos,
        GerenciarProjetos,
        GerenciarTipoUsuario,
        CadastrarUsuario,
        GerenciarUsuarios,
        Equipes
    },
    {
        swipeEnabled : true,
        tabBarPosition : 'bottom',
        tabBarOptions : {
            showIcon : false,
            showLabel : true,
            labelStyle : {
                alignItems : 'center'
            },
            pressColor : '#f5898d',
            indicatorStyle : { backgroundColor : '#f5898d', height : 3 },
            style: {
                backgroundColor : '#a50d12',
                height : 50
            }
        }
    }
)

export default createAppContainer(ProjetosNavigator);