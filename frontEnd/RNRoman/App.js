import React, { Component } from 'react';
import { StyleSheet, Text, View, Button } from 'react-native';

import { createAppContainer, createDrawerNavigator } from 'react-navigation';

import Login from './src/pages/LoginScreen';
import HomeAdm from './src/pages/homeadm';
import GerenciarTipoUsuario from './src/pages/gerenciartipousuario';
import Equipes from './src/pages/equipes';
import GerenciarUsuarios from './src/pages/gerenciarusuarios';
import CadastrarUsuario from './src/pages/cadastrarusuario';
import Temas from './src/pages/temas';
import HomePro from './src/pages/homepro';
import GerenciarProjetos from './src/pages/gerenciarprojetos';
import CadastrarProjeto from './src/pages/cadastrarprojeto';

export default class App extends Component {
    render() {
        return (
            <AppContainer />
        );
    }
}

const AppDrawerNavigator = createDrawerNavigator({
    Login: Login,
    HomeAdm: HomeAdm,
    GerenciarTipoUsuario: GerenciarTipoUsuario,
    Equipes: Equipes,
    GerenciarUsuarios: GerenciarUsuarios,
    CadastrarUsuario: CadastrarUsuario,
    Temas: Temas,
    HomePro: HomePro,
    GerenciarProjetos: GerenciarProjetos,
    CadastrarProjeto: CadastrarProjeto,
},{
    initialRouteName: 'Login'
}
)

const AppContainer = createAppContainer(AppDrawerNavigator);

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#fff',
        alignItems: 'center',
        justifyContent: 'center',
    },
});